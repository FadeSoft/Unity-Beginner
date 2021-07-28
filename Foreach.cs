using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foreach : MonoBehaviour
{
    void Start()
    {
        string[] yemekler = { "elma", "armut", "ahben" };

        foreach (var item in yemekler)
        {
            Debug.Log(item);
        }
    }

   
}
