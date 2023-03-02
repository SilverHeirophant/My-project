using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBounds : MonoBehaviour
{
    private float zRange = 88.0f;
    private float altZRange = -99.0f;
    private float xRange = 86.0f;
    private float altXRange = -87.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < altXRange)
        {
            transform.position = new Vector3(altXRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < altZRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, altZRange);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }
    }
}
