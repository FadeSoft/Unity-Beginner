using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temelFonksyionlar : MonoBehaviour
{
    private void Awake()
    {
        //Açýlýþta ilk çalýþacak olan fonksiyondur.
        //Sadece bir kez çalýþýr.
        Debug.Log("Ben awake ile geldim.");
    }
    private void OnEnable()
    {
        //Örneðin bu fonksiyonun oldugu scripti küp objesine attým.
        //Küp objesi aktif ise bu fonk çalýþýr.
        //Sadece bir kez çalýþýr.

        Debug.Log("Ben onEnable ile geldim");
    }

    void Start()
    {
        //Script çalýþtýðýnda bu fonksiyon çalýþýr.
        //Sadece bir kez çalýþýr.
        Debug.Log("Ben start ile geldim");
    }

    //Güncelleme fonksiyonlarý
    void Update()
    {
        //Update methodu oyun çalýþýrken her karede- framede çalýsýr.
        //Optimize açýsýndan iyi deðil!!! 
        //Default ayarlar için her 1 saniyede bir çalýþýr.

        Debug.Log("Ben Update ile sürekli geliyorum");

    }
    private void FixedUpdate()
    {
        //Update methodundan daha sýk aralýklarla çalýþýr.
        //Default ayarlar için her 0.22 saniyede bir çalýþýr.
        Debug.Log("Ben FixedUpdate ile sürekli geliyorum");
    }
    private void LateUpdate()
    {
        //Sahnedeki tüm update methodlarýnýn çalýþmasý bittikten sonra çalýþýr.
        Debug.Log("Ben LateUpdate ile sürekli geliyorum");
    }

    private void OnDisable()
    {
        //Örneðin bu fonksiyonun oldugu scripti küp objesine attým.
        //Küp objesi deaktif ise bu fonk çalýþýr.
        //Sadece bir kez çalýþýr.
        Debug.Log("Ben OnDisable ile  geldim");
    }
}
