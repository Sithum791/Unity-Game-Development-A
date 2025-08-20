using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogForceDirection : MonoBehaviour
{
    public float forceAmount = 10f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 force = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            force = Vector3.forward * forceAmount;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            force = Vector3.back * forceAmount;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            force = Vector3.left * forceAmount;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            force = Vector3.right * forceAmount;
        }

       
        if (force != Vector3.zero)
        {
            rb.AddForce(force);

            
            Debug.Log("Force Direction: " + force.normalized + " | Magnitude: " + force.magnitude);
        }
    }
}
