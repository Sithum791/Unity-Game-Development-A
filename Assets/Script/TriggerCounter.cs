using UnityEngine;

public class TriggerCounter : MonoBehaviour
{
    private int triggerCount = 0; // Keeps track of how many triggers entered

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            triggerCount++;
            Debug.Log("Player entered triggers: " + triggerCount + " times");
        }
    }
}
