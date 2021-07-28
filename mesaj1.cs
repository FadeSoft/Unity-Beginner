using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesaj1 : MonoBehaviour
{
    void Start()
    {
        gameObject.SendMessage("ekranabas","samet",SendMessageOptions.RequireReceiver);

        //sendmessage ile fonksiyon tetikleyebilirim
        //Fonksiyon parametre alýyorsa , den sonra onu belirtebilirim.
        //Eðer alýcý ayarý yapmak istersem sonuna SendMessageOptions eklerim. Alýcý zorunludur olmazsa hata verir.

        gameObject.BroadcastMessage("ekranabas2"); 
        //mesaj2.cs ye bak
        // Bu objenin tüm cocuklarýna kadar eriþir orada fonk varsa ona gider.

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
