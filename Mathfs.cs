using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mathfs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        print(Math.Abs(-2f));
        print(Mathf.Abs(-2f));

        print(Mathf.Ceil(5.2f));
        print(Mathf.Ceil(5.7f));

        print(Mathf.Floor(5.2f));
        print(Mathf.Floor(5.7f));

        print(Mathf.Round(5.2f));
        print(Mathf.Round(5.7f));


    }

    // Update is called once per frame
    void Update()
    {

    }
}
