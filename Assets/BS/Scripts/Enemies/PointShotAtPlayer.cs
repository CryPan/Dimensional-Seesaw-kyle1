﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointShotAtPlayer : MonoBehaviour
{
    public GameObject TargetPoint = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 toPlayer = TargetPoint.transform.position - transform.position;
        toPlayer.y += 1;
        Quaternion targetRot = Quaternion.LookRotation(toPlayer, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, 300);
    }
}
