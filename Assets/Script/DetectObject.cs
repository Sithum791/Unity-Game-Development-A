using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject goalObject = GameObject.FindWithTag("Goal");

        if (goalObject != null)
        {
            Debug.Log("Goal object found: " + goalObject.name);
        }
        else
        {
            Debug.Log("No object with tag 'Goal' found in the scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
