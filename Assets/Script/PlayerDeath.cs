using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Hazard"))
        {
            Debug.Log("Player hit a hazard! Destroying player...");
            Destroy(gameObject); // Destroy the player
        }
    }

    // Optional version if the hazard uses a trigger collider
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hazard"))
        {
            Debug.Log("Player hit a hazard! Destroying player...");
            Destroy(gameObject);
        }
    }
}

