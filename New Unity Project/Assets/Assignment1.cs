using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment1 : MonoBehaviour
{
    public GameObject Cirkel;

    void Start()
    {
        Spawn();
    }



    void Spawn()
    {
        int x = -30;
        for (int i = 0; i < 100; i++)
        {
            Instantiate(Cirkel, new Vector2(x++, -10), Quaternion.identity);
        }
    }
}
