using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    // Invoke bizim belirde�imiz fonksiyonu belirli bir s�re �al��t�r�r.
    void Start()
    {
        //Invoke("Yaz�Yaz", 2f); //Yaz�Yaz fonksiyonu 2 sn beklet sonra a�.
       InvokeRepeating("Yaz�Yaz", 1f, .5f); //1sn bekleyip Yaz�Yaz fonksiyonunu �al��t�racak. Sonra her 3 saniyede bir tekrar edecek.
       
    }

    void Yaz�Yaz()
    {
        print(Time.deltaTime);
        Debug.Log("1f ge�ti");


        Debug.Log("Ben fonksiyodan geliyorum");
    }
     void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            CancelInvoke(); //T�m invokeleri kapat�r.
        }   

        if (IsInvoking("Yaz�Yaz")) //Yaz�Yaz fonksiyonu �al���yor mu ?
        {
            Debug.Log("Yaz�Yaz FONKS�YONU CALISIYOR.");
        }
        else
        {
            Debug.Log("Hay�r");
        }
    }
}
