using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseClickShow : MonoBehaviour
{
    bool show = true;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            if (show) {
                show = false;
            }
            else show = true;
            gameObject.GetComponent<Renderer>().enabled = show;
        }
    }
}
