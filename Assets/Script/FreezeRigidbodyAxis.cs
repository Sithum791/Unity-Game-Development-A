using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeRigidbodyAxis : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();


        rb.constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
