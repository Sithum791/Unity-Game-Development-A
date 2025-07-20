using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagToggle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            // Toggle tag between "Active" and "Inactive"
            if (gameObject.tag == "Active")
            {
                gameObject.tag = "Inactive";
                Debug.Log("Tag changed to Inactive");
            }
            else if (gameObject.tag == "Inactive")
            {
                gameObject.tag = "Active";
                Debug.Log("Tag changed to Active");
            }
        }
    }
}
