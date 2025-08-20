using UnityEngine;

public class PushOtherObject : MonoBehaviour
{
    public float pushForce = 5f; 

    void OnCollisionEnter(Collision collision)
    {
    
        Rigidbody otherRb = collision.rigidbody;

       
        if (otherRb != null && !otherRb.isKinematic)
        {
           
            Vector3 pushDirection = collision.transform.position - transform.position;
            pushDirection.y = 0; 

            
            otherRb.AddForce(pushDirection.normalized * pushForce, ForceMode.Impulse);
        }
    }
}
