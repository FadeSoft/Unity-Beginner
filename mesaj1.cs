using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesaj1 : MonoBehaviour
{
    void Start()
    {
        gameObject.SendMessage("ekranabas","samet",SendMessageOptions.RequireReceiver);

        //sendmessage ile fonksiyon tetikleyebilirim
        //Fonksiyon parametre al�yorsa , den sonra onu belirtebilirim.
        //E�er al�c� ayar� yapmak istersem sonuna SendMessageOptions eklerim. Al�c� zorunludur olmazsa hata verir.

        gameObject.BroadcastMessage("ekranabas2"); 
        //mesaj2.cs ye bak
        // Bu objenin t�m cocuklar�na kadar eri�ir orada fonk varsa ona gider.

    }


    void ekranabas(string ad)
    {
        Debug.Log("selam"+ad);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
