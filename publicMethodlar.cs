using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicMethodlar : MonoBehaviour
{
    // public
    // private , fonksiyonlar�n �z nitelikleri

    private IEnumerator birincicont; //Coroutine yi de�i�ken gibi tan�mlad�m. �stedi�im yerden kontrol edebilece�im.

    void Start()
    {
        StartCoroutine(Deneme()); //Deneme coroutinesini ba�lat
        StartCoroutine(Deneme2(5)); //Deneme2 coroutinesini ba�lat

        birincicont = Deneme2(2); //Burda birincicont u IEnumator olarak tan�mlad�k. Sonra bu de�i�kenin hangi coroutine oldugunu belirledik.


        //Coroutine Update methodu gibidir fakat update gibi her karede-frame de �al��maz.
        //Olu�turdugumuz coroutineler istedi�imiz zaman diliminde �al��abilir ve istedi�imiz zaman durdurabiliriz.
    }

    private void Update()
    {
        if (Input.GetKeyDown("space")) //Space tu�una basarsam
        {
            Debug.Log("baslad�");

            StartCoroutine(birincicont); //birincicont coroutinesini ba�lat
        }
        if (Input.GetKeyDown("x")) //X tu�una basarsam
        {
            Debug.Log("bitti");
            StopCoroutine(birincicont); // birincicont coroutinesini durdur
        }

    }
    public void y�kleBtn() //Burada da coroutine yi buton fonksiyonuna baglad�m.
    {
        birincicont = Deneme2(3);
        StartCoroutine(birincicont);
        //Butona bu �ekilde atan�r.
    }

    IEnumerator Deneme()
    {
        Debug.Log("1. deneme");
        yield return null; // bir frame bekletir
        Debug.Log("2. deneme");

        //1. �nce kodlar�m�z
        //2. Bekleme zaman�
        //3. Var ise di�er kodlar
        //Kullan�m� bu �ekilde olmal�
    }

    IEnumerator Deneme2(float saniye)
    {
        Debug.Log("baska bir deneme zaman i�in");
        yield return new WaitForSeconds(saniye);
        Debug.Log("7 san�ye bitti");
        yield return StartCoroutine(sondeneme()); //Bir coroutine biterden bu �ekilde ba�ka coroutineyi ba�latabiliriz.
    }

    IEnumerator sondeneme()
    {
        Debug.Log("ben en sonum");
        yield return null; //Bir framde de �al��
        
    }

}
