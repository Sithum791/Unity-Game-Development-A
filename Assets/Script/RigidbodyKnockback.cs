using UnityEngine;

public class RigidbodyKnockback : MonoBehaviour
{
    public Rigidbody rb;               // Player's Rigidbody
    public float knockbackForce = 5f;  // Strength of the push

    private void Awake()
    {
        if (!rb) rb = GetComponent<Rigidbody>(); // Auto-assign if not set
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object is an enemy
        if (collision.gameObject.CompareTag("Enemy"))
        {
            // Calculate direction away from enemy
            Vector3 knockbackDirection = (transform.position - collision.transform.position).normalized;

            // Apply force in that direction
            rb.AddForce(knockbackDirection * knockbackForce, ForceMode.Impulse);
        }
    }
}
