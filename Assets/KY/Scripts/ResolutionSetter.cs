using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResolutionSetter : MonoBehaviour
{
    Dropdown _dropdown;

    // Start is called before the first frame update
    void Start()
    {
        _dropdown = GetComponent<Dropdown>();
        _dropdown.options.Clear();
        Resolution[] res = Screen.resolutions;
        for (int i = 0; i <res.Length; i++)
        {
            Dropdown.OptionData data = new Dropdown.OptionData(res[i].ToString());
            _dropdown.options.Add(data);
            if (res[i].Equals(Screen.currentResolution))
                _dropdown.value = i;
        }
    }

    public void OnChange (int value)
    {
        Resolution res = Screen.resolutions[value];
        Screen.SetResolution(res.width, res.height, Screen.fullScreen);
    }

}
