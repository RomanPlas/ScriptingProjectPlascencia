using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataType : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 pos = transform.position;
        pos = new Vector3(0, 1, 0);

        Transform tran = transform;
        tran.position = new Vector3(0, 4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
