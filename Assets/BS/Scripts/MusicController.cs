using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour
{
    DimensionSwitcher dimSwitcher;

    public AudioSource MedievalMusic;
    public AudioSource ScifiMusic;
    public AudioSource Squish;
    public AudioSource Crash;

    bool isOldWorld = true;

    // Start is called before the first frame update
    void Start()
    {
        dimSwitcher = GetComponent<DimensionSwitcher>();
        MedievalMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        SwtichAudio();
    }

    public void PlayDeath(bool squish)
    {
        if(squish)
        {
            Squish.Play();
        }
        else
        {
            Crash.Play();
        }
        
    }

    private void SwtichAudio()
    {
        if (dimSwitcher.isOld != isOldWorld)
        {
            if (dimSwitcher.isOld)
            {
                // Play Medieval Music
                MedievalMusic.Play();
                ScifiMusic.Pause();
                Debug.Log("Medieval Music Playing: " + MedievalMusic.isPlaying);
            }
            else
            {
                // Play Scifi Music
                ScifiMusic.Play();
                MedievalMusic.Pause();
                Debug.Log("Scifi Music Playing: " + ScifiMusic.isPlaying);
            }
            isOldWorld = dimSwitcher.isOld;
        }
    }
}
