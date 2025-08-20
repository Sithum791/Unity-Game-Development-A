using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleOverTime : MonoBehaviour
{
    public Vector3 startScale = new Vector3(1f, 1f, 1f);
    public Vector3 endScale = new Vector3(3f, 3f, 3f);
    public float duration = 5f;

    private float elapsedTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = startScale;
    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / duration;   // 0 → 1 over time
            transform.localScale = Vector3.Lerp(startScale, endScale, t);
        }
    }
}
