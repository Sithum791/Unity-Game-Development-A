using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Zone"))
        {
            Debug.Log("Player entered the Zone!");
        }
    }

    // Optional: Called when leaving the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Zone"))
        {
            Debug.Log("Player left the Zone!");
        }
    }
}
