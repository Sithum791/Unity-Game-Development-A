using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderActivationDelay : MonoBehaviour
{
    public Collider hiddenCollider; 
    public float activationDelay = 5f;

    
    void Start()
    {
        
        hiddenCollider.enabled = false;

        
        Invoke("ActivateCollider", activationDelay);
    }

    void ActivateCollider()
    {
        hiddenCollider.enabled = true;
        Debug.Log("Collider is now active!");
    }
}
