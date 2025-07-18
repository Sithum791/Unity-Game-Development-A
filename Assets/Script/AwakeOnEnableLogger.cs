using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeOnEnableLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log("Game Started");
    }

    // Update is called once per frame
    void OnEnable()
    {
        Debug.Log("Object Enabled");
    }
}
