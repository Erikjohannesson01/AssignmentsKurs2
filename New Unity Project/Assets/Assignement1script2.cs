using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignement1script2 : MonoBehaviour
{
    public GameObject Circle;
    float startingVal;
    public float speed = 0;
    public float amplitude = 0;

    void Start()
    {
        startingVal = transform.position.x;
    }

    
    void Update()
    {
        Sine(speed, amplitude);
    }
    void Sine(float speed, float amplitude)
    {
        float x = transform.position.x;
        float y = Mathf.Sin(Time.time * speed + startingVal) * amplitude;
        transform.position = new Vector2(x, y);
    }
}
