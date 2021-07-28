using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    // Invoke bizim belirdeðimiz fonksiyonu belirli bir süre çalýþtýrýr.
    void Start()
    {
        //Invoke("YazýYaz", 2f); //YazýYaz fonksiyonu 2 sn beklet sonra aç.
       InvokeRepeating("YazýYaz", 1f, .5f); //1sn bekleyip YazýYaz fonksiyonunu çalýþtýracak. Sonra her 3 saniyede bir tekrar edecek.
       
    }

    void YazýYaz()
    {
        print(Time.deltaTime);
        Debug.Log("1f geçti");


        Debug.Log("Ben fonksiyodan geliyorum");
    }
     void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CancelInvoke(); //Tüm invokeleri kapatýr.
        }   

        if (IsInvoking("YazýYaz")) //YazýYaz fonksiyonu çalýþýyor mu ?
        {
            Debug.Log("YazýYaz FONKSÝYONU CALISIYOR.");
        }
        else
        {
            Debug.Log("Hayýr");
        }
    }
}
