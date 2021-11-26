using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class BossMusic : MonoBehaviour
{
    public AudioSource MedievalMusic;
    public AudioSource ScifiMusic;

    public GameObject Music;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ScifiBossMusic()
    {
        Debug.Log("Scifi Boss Music");
        Music.SetActive(false);
        MedievalMusic.Pause();
        ScifiMusic.Play();
    }

    public void MedievalBossMusic()
    {
        Debug.Log("Medieval Boss Music");
        Music.SetActive(false);
        ScifiMusic.Pause();
        MedievalMusic.Play();
    }
}
