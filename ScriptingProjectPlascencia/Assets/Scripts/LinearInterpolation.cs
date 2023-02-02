using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{/*
    // In this case, result = 4
    float result = Mathf.Lerp (3f, 5f, 0.5f);
    // Mathf.Lerp takes 3 float parametters reppresying value to interpolate from, interpolate to and how far to interpolate. If the object is 0 it would return the " from value", if 1 it would return the "to" value
    


    Vector3 from new Vector3 (1f, 2f, 3f);
    Vector3 to = new Vector3 (5f, 6f, 7f);

    // Here result = (4, 5, 6)
    Vector3 result = Vector3.Lerp (from, to, 0.75f);
    // 4,5,6 is the result because 4 is 75% between 1-5, 5 is 75% between 2-6, 6 is 75% between 3-7. These floats usiong Mathf.Lerp and Vector3.Lerp are the same as Color.Lerp which represeents 4 floats red, blue, green and alpha
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity =  Mathf.Lerp(light.intensity, 8f, 0.5f);
        // if the intensity of the light starts off at 0 the first update will set it to 4, then 6, then 7, then 7.5 until it reaches 8. This happens over several frames and the rate of change will slow approaching thee target.
    }

    {
       light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
       //  The change of intensity would happen per second instead of each frame
    }

    
  */
}
