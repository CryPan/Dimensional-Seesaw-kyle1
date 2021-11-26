using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;
using UnityEngine.Rendering.PostProcessing;

public class DimensionSwitcher : MonoBehaviour
{
    public AudioSource DimSwitchAudio;
    public bool isOld = true;
    public PlayerMovement movementScript = null;
    public CharacterController charCont = null;

    float playerSwitching = 0;
    public float TimeBetweenSwitching = 1f;
    float switchingTimer;
    bool canSwitch = false;

    public PostProcessVolume _volume;
    LensDistortion _lensDistortion;

    public PlayableDirector HandMove;

    public int switchAmount = 100;

    // Update is called once per frame

    private void Start()
    {
        _volume.profile.TryGetSettings<LensDistortion>(out _lensDistortion);
    }
    void Update()
    {


        if (playerSwitching > 0.1 && !Settings.isPaused && canSwitch)
        {
            PlayHandMove();
            DimSwitchAudio.Play();
        }
        else if (!canSwitch)
        {
            if (switchingTimer > 0)
            {
                switchingTimer -= Time.deltaTime;
            }
            else
            {
                switchingTimer = TimeBetweenSwitching;
                canSwitch = true;
            }
        }
    }

    public void RecieveSwitchInput(float isSwitching)
    {
        playerSwitching = isSwitching;
    }

    void SwitchDim()
    {
        if(isOld)
        {
            charCont.enabled = false;
            transform.position = new Vector3(transform.position.x - switchAmount, transform.position.y, transform.position.z);
            charCont.enabled = true;
            isOld = false;
        }
        else
        {
            charCont.enabled = false;
            transform.position = new Vector3(transform.position.x + switchAmount, transform.position.y, transform.position.z);
            charCont.enabled = true;
            isOld = true;
        }
    }

    void PlayHandMove()
    {
        HandMove.Play();
        StartCoroutine(FlashFX());
        SwitchDim();
        
        canSwitch = false;
    }

    IEnumerator FlashFX()
    {
        float alpha = -100f;
        while (alpha < 0)
        {
            alpha += 1 / 0.005f * Time.deltaTime;
            _lensDistortion.intensity.value = alpha;
            yield return new WaitForEndOfFrame();
        }
    }
}
