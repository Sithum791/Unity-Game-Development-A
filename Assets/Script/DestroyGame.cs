using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //destroy game object
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
