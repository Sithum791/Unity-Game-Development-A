using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ChangeTagOnTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
      
        if (other.CompareTag("Player"))
        {
            
            gameObject.tag = "Collected";
            Debug.Log(gameObject.name + " is now Collected!");
        }
    }
}
