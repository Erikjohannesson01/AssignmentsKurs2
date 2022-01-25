using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignmentcirclerunt : MonoBehaviour
{
    Assignment1 Round;

    // Start is called before the first frame update
    void Start()
    {
        Round = GameObject.FindObjectOfType(typeof(Assignment1)) as Assignment1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Round.holdcc != Round.cc)
        {
            Invoke(nameof(Changesize), 0.01f);
        }
    }


    void Changesize()
    {
        Round.holdcc = Round.cc;
        Destroy(gameObject);
    }
}
