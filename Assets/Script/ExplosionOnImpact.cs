using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ExplosionOnImpact : MonoBehaviour
{
    public GameObject explosionPrefab;  // Assign the particle prefab in Inspector

    void OnCollisionEnter(Collision collision)
    {
        // Instantiate explosion at this object's position
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }

        // Optional: Destroy the projectile
        Destroy(gameObject);
    }
}
