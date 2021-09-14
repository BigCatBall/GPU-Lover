using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rgbColor : MonoBehaviour
{
    public GameObject floorObj;



    float hue = 0f;
    float sat = 0f;
    float val = 0f;

    // Update is called once per frame
    void Update()
    {
        if (hue < 360)
        {
            hue = hue + 0.1f;
        }
        else if (hue > 360)
        {
            hue = 0f;
        }

        Debug.Log(hue);
        floorObj.gameObject.GetComponent<Renderer>().material.color = Color.HSVToRGB(hue, sat, val);
    }
}
