﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float speed = 1f;
    void Update()
    {
        transform.Rotate(0, 0, speed, Space.Self);
    }
}
