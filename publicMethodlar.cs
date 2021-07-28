using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class publicMethodlar : MonoBehaviour
{
    // public
    // private , fonksiyonlarýn öz nitelikleri

    private IEnumerator birincicont; //Coroutine yi deðiþken gibi tanýmladým. Ýstediðim yerden kontrol edebileceðim.

    void Start()
    {
        StartCoroutine(Deneme()); //Deneme coroutinesini baþlat
        StartCoroutine(Deneme2(5)); //Deneme2 coroutinesini baþlat

        birincicont = Deneme2(2); //Burda birincicont u IEnumator olarak tanýmladýk. Sonra bu deðiþkenin hangi coroutine oldugunu belirledik.


        //Coroutine Update methodu gibidir fakat update gibi her karede-frame de çalýþmaz.
        //Oluþturdugumuz coroutineler istediðimiz zaman diliminde çalýþabilir ve istediðimiz zaman durdurabiliriz.
    }

    private void Update()
    {
        if (Input.GetKeyDown("space")) //Space tuþuna basarsam
        {
            Debug.Log("basladý");

            StartCoroutine(birincicont); //birincicont coroutinesini baþlat
        }
        if (Input.GetKeyDown("x")) //X tuþuna basarsam
        {
            Debug.Log("bitti");
            StopCoroutine(birincicont); // birincicont coroutinesini durdur
        }

    }
    public void yükleBtn() //Burada da coroutine yi buton fonksiyonuna bagladým.
    {
        birincicont = Deneme2(3);
        StartCoroutine(birincicont);
        //Butona bu þekilde atanýr.
    }

    IEnumerator Deneme()
    {
        Debug.Log("1. deneme");
        yield return null; // bir frame bekletir
        Debug.Log("2. deneme");

        //1. Önce kodlarýmýz
        //2. Bekleme zamaný
        //3. Var ise diðer kodlar
        //Kullanýmý bu þekilde olmalý
    }

    IEnumerator Deneme2(float saniye)
    {
        Debug.Log("baska bir deneme zaman için");
        yield return new WaitForSeconds(saniye);
        Debug.Log("7 sanýye bitti");
        yield return StartCoroutine(sondeneme()); //Bir coroutine biterden bu þekilde baþka coroutineyi baþlatabiliriz.
    }

    IEnumerator sondeneme()
    {
        Debug.Log("ben en sonum");
        yield return null; //Bir framde de çalýþ
        
    }

}
