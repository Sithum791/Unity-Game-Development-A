using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupDestroy : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Player picked up: " + gameObject.name);
            Destroy(gameObject); 
        }
    }
}