using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignementscript3 : MonoBehaviour
{
    float startingVal;
    public float speed = 0;
    public float amplitude = 0;

    void Start()
    {
        startingVal = transform.position.x;
    }


    void Update()
    {
        Cos(speed, amplitude);
    }
    void Cos(float speed, float amplitude)
    {
        float x = transform.position.x;
        float y = Mathf.Cos(Time.time * speed + startingVal) * amplitude;
        transform.position = new Vector2(x, y + 4);
    }
}

