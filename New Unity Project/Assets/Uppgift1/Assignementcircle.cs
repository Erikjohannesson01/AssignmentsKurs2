using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignementcircle : MonoBehaviour
{
    // Start is called before the first frame update

    float turning = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turning += Time.time;

        float x = Mathf.Cos(turning);
        float y = Mathf.Sin(turning);

        transform.position = new Vector2(x, y);
    }
}
