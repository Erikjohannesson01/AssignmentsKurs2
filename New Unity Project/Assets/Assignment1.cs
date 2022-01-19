using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    public GameObject Cirkel;
    public GameObject Cirkel2;
    public GameObject Cirkel3;


    public float cc;
    public float holdcc;

    void Start()
    {
        Spawn();
        circle();
        holdcc = cc;
    }

    private void Update()
    {
        if (holdcc != cc)
        {
            circle();
        }
    }


    void Spawn()
    {
        
        for (float i = -30; i < 100; i += 0.3f)
        {
            Instantiate(Cirkel, new Vector2(i -1, 0), Quaternion.identity);
            Instantiate(Cirkel2, new Vector2(i -1, 0), Quaternion.identity);
        }

       
    }

    private void circle()
    {
        for (float x = 0; x < Mathf.PI * 2; x += 0.1f)
        {

            Instantiate(Cirkel3, new Vector2(Mathf.Cos(x) * cc, Mathf.Sin(x) * cc), Quaternion.identity);
        }
        
    }
}
