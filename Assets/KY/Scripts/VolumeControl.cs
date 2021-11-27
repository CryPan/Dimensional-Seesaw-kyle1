using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class VolumeControl : MonoBehaviour
{
    public AudioMixer Mixer;
    public string ParamName;
    Slider _slider;
    public float Default;

    void Start()
    {
        _slider = GetComponent<Slider>();
        PlayerPrefs.SetFloat(ParamName, Default);
        float vol = PlayerPrefs.GetFloat(ParamName);
        _slider.value = vol;
        Change(vol);
    }


    public void Change(float value)
    {
        PlayerPrefs.SetFloat(ParamName, value);
        value *= 80;
        value -= 80;
        Mixer.SetFloat(ParamName, value);
        
    }
}
