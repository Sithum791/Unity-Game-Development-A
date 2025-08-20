using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneMessage : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Only detect Player
        {
            Debug.Log("Player has entered the trigger zone!");
        }
    }
}