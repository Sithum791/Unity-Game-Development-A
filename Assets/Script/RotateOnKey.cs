using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnKey : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //rotate y axis
            transform.Rotate(0f, 90f, 0f);
        }
    }
}
