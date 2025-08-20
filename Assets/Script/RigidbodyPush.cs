using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyPush : MonoBehaviour
{
    public float moveForce = 10f; // force strength
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get arrow key input
        float moveX = Input.GetAxis("Horizontal"); // Left/Right (Arrow keys or A/D)
        float moveZ = Input.GetAxis("Vertical");   // Up/Down (Arrow keys or W/S)

        // Create direction vector
        Vector3 moveDirection = new Vector3(moveX, 0f, moveZ);

        // Apply force in that direction
        rb.AddForce(moveDirection * moveForce);
    }
}