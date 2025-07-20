using UnityEngine;

public class DynamicScaler : MonoBehaviour
{
    void Start()
    {
        //The function "ScaleUp" runs automatically once every 1 second.
        InvokeRepeating("ScaleUp", 0f, 1f);
    }

    void ScaleUp()
    {
        transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);
        Debug.Log("Scaled to: " + transform.localScale);
    }
}
