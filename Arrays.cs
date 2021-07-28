using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    public int[] values;
    void Start()
    {
        int[] sayilar = new int[2] { 1, 2 };
        int[] sayilar2 = new int[] { 1, 2, 3 };

        values[0] = 10;

        int[][] sayilar3 = new int[2][];

        for (int i = 0; i < sayilar2.Length; i++)
        {
            Debug.Log(sayilar2[i]);
        }

    }
}


