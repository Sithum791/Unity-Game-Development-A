using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothStop : MonoBehaviour
{

    public Rigidbody rb;
    public float moveSpeed = 5f;
    public float dragAmount = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb.drag = dragAmount;
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * move * moveSpeed, ForceMode.Force);
    }
}
