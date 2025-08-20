using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedDetection : MonoBehaviour
{
    public bool isGrounded = false;

    private void OnCollisionEnter(Collision collision)
    {
      
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
   
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
