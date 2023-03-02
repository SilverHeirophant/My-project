using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    private float topBound = 98.0f;
    private float bottomBound = 97.0f;
    public float speed = 20.0f;
    private Vector3 offset = new Vector3 (20, 20, 4); 
    Rigidbody rb;

    // Start is called before the first frame update
    void Awake()
    {
        

        rb = GetComponent<Rigidbody>();
    }
    //Moves the bullet forwards from player location
    public void Launch(Vector3 direction, float force)
    {
        rb.AddForce(direction * force);
    }

    // Update is called once per frame
    void Update()
    {
        //if it meets the conditions, destroy bullet
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > bottomBound)
        {
          Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //if meets enemy or other obj, destroy BOTH gameObject and bullet
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
