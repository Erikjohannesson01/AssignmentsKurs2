using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    public GameObject Cirkel;
    public GameObject Cirkel2;

    void Start()
    {
        Spawn();
    }



    void Spawn()
    {
        float x = -10;
        for (int i = 0; i < 100; i++)
        {
            Instantiate(Cirkel, new Vector2(x += 0.3f, 0), Quaternion.identity);
        }
        float e = -10;
        for (int i = 0; i < 100; i++)
        {
            Instantiate(Cirkel2, new Vector2(e += 0.3f, 0), Quaternion.identity);
        }
    }
}
