﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class HandMove : MonoBehaviour
{
    public PlayableDirector HandMovetojump;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        Debug.Log(Time.deltaTime);
    }

}
