using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnTriggerExit : MonoBehaviour
{
    public GameObject prefabToSpawn;   // Assign prefab in Inspector
    public Vector3 spawnAreaMin = new Vector3(-5, 0, -5); // Min spawn boundary
    public Vector3 spawnAreaMax = new Vector3(5, 0, 5);   // Max spawn boundary

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Generate a random position within the defined area
            float x = Random.Range(spawnAreaMin.x, spawnAreaMax.x);
            float y = Random.Range(spawnAreaMin.y, spawnAreaMax.y);
            float z = Random.Range(spawnAreaMin.z, spawnAreaMax.z);
            Vector3 randomPos = new Vector3(x, y, z);

            // Instantiate the prefab
            Instantiate(prefabToSpawn, randomPos, Quaternion.identity);

            Debug.Log("Spawned new object at: " + randomPos);
        }
    }
}
