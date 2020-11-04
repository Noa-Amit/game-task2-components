using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class sizeChanger : MonoBehaviour
{
    double minSize = 1f;
    float maxSize = 5f;
    float direction = 1f;

    // Update is called once per frame
    void Update()
    {    
        if (transform.localScale.x <= minSize || transform.localScale.x >= maxSize)
            direction = direction*(-1f); 
        Vector3 add = new Vector3(0.01f,0.01f,0.01f);    
        transform.localScale += add*direction;
    }
}
