using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class List : MonoBehaviour
{
    public List<int> yaslar = new List<int>();
    public List<int> yas;
    
    void Start()
    {
        //List<int> yaslar = new List<int>();

        yaslar.Add(40);
        yaslar.Add(0);
        yaslar.Add(10);//Sonuna ekler
        

        yaslar.Insert(1, 90);
        for (int i = 0; i < yaslar.Count; i++)
        {
            Debug.Log(yaslar[i]);
        }
        yaslar.Remove(40);
        for (int i = 0; i < yaslar.Count; i++)
        {
            Debug.Log(yaslar[i]);
        }

        if (yaslar.Contains(89))
        {
            Debug.Log("Yaslar listesinin altýnda 89 elemaný var.");
        }
        else
        {
            Debug.Log("Yaslar listesinin altýnda 89 elemaný YOK.");

        }

        yaslar.Clear();//Listeyi tamamen temizler.

        Debug.LogError("s");
    }
}
    
