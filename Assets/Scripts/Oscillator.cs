using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField]
    double speed = 20;
    [SerializeField]
    float length = 20f;
    Vector3 center;

    // Start is called before the first frame update
    void Start()
    {
        center = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 l = new Vector3(length,0,0);
        transform.position = center + new Vector3((float)Math.Sin(Time.time * speed),0,0);
    }
}
