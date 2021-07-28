using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temelFonksyionlar : MonoBehaviour
{
    private void Awake()
    {
        //A��l��ta ilk �al��acak olan fonksiyondur.
        //Sadece bir kez �al���r.
        Debug.Log("Ben awake ile geldim.");
    }
    private void OnEnable()
    {
        //�rne�in bu fonksiyonun oldugu scripti k�p objesine att�m.
        //K�p objesi aktif ise bu fonk �al���r.
        //Sadece bir kez �al���r.

        Debug.Log("Ben onEnable ile geldim");
    }

    void Start()
    {
        //Script �al��t���nda bu fonksiyon �al���r.
        //Sadece bir kez �al���r.
        Debug.Log("Ben start ile geldim");
    }

    //G�ncelleme fonksiyonlar�
    void Update()
    {
        //Update methodu oyun �al���rken her karede- framede �al�s�r.
        //Optimize a��s�ndan iyi de�il!!! 
        //Default ayarlar i�in her 1 saniyede bir �al���r.

        Debug.Log("Ben Update ile s�rekli geliyorum");

    }
    private void FixedUpdate()
    {
        //Update methodundan daha s�k aral�klarla �al���r.
        //Default ayarlar i�in her 0.22 saniyede bir �al���r.
        Debug.Log("Ben FixedUpdate ile s�rekli geliyorum");
    }
    private void LateUpdate()
    {
        //Sahnedeki t�m update methodlar�n�n �al��mas� bittikten sonra �al���r.
        Debug.Log("Ben LateUpdate ile s�rekli geliyorum");
    }

    private void OnDisable()
    {
        //�rne�in bu fonksiyonun oldugu scripti k�p objesine att�m.
        //K�p objesi deaktif ise bu fonk �al���r.
        //Sadece bir kez �al���r.
        Debug.Log("Ben OnDisable ile  geldim");
    }
}
