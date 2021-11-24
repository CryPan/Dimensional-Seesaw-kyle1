using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public GameObject FlashObject = null;
    Material mat;


    public float EnemyHP = 1000;
    public RectTransform HealthPanel = null;
    public float HitDuration = 0.5f;

    float CurrentHP;

    // Start is called before the first frame update
    void Start()
    {
        if(FlashObject.GetComponent<MeshRenderer>() == null)
        {
            mat = FlashObject.GetComponent<SkinnedMeshRenderer>().materials[0];
        }
        else
        {
            mat = FlashObject.GetComponent<MeshRenderer>().materials[1];
        }
        
        CurrentHP = EnemyHP;
    }

    public void TakeDamage(int amount)
    {
        StartCoroutine(FlashFX());
        CurrentHP -= amount;
        HealthPanel.anchorMax = new Vector2(CurrentHP / EnemyHP, 1);
        if (CurrentHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    IEnumerator FlashFX()
    {
        float alpha = 0.5f;
        while (alpha > 0)
        {
            alpha -= 1 / HitDuration * Time.deltaTime;
            mat.color = new Color(1, 1, 1, alpha);
            //_vignette.intensity.value = alpha;
            yield return new WaitForEndOfFrame();
        }
    }
}
