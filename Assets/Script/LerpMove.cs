using UnityEngine;

public class LerpMove : MonoBehaviour
{
    //point A
    public Vector3 pointA = new Vector3(0f, 0f, 0f);

    //Point B
    public Vector3 pointB = new Vector3(5f, 0f, 0f);
    public float speed = 1f;

    private float t = 0f;

    void Update()
    {
        
        t += Time.deltaTime * speed;

        // to move back and front between 0 and 1
        float lerpValue = Mathf.PingPong(t, 1f);

        // to move the object between A and B
        transform.position = Vector3.Lerp(pointA, pointB, lerpValue);
    }
}
