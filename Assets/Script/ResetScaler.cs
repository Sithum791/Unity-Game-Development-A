using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScaler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // R key press checking
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale = Vector3.one;
            Debug.Log("Scale reset to (1, 1, 1)");
        }
    }
}
