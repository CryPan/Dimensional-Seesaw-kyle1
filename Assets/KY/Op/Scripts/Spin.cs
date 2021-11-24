using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float Speed = 6f;
    void Update()
    {
        transform.Rotate(Vector3.up * Speed * Time.deltaTime);
    }
}
