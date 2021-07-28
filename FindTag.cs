using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTag : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject[] cokluobje;
    void Start()
    {
        GameObject.Find("cube").GetComponent<Getcomponent>().k�p.name = "samet";
        GameObject.Find("Ana/Cocuk").GetComponent<Getcomponent>().k�p.name = "samet";

        //Find methodu oyundaki t�m sahneler aras�nda arama yapar. Bu y�zden performans a��s�ndan iyi olmad��� i�in genelde kullan�lmaz.

        GameObject.FindWithTag("enemy");
        //Tag ile aramak daha performansl�

        transform.Find("Cocuk").GetComponent<AudioClip>().name = "xzx";
        //Daha performansl�.Child bulman�n bir farkl� y�ntemi

        cokluobje= GameObject.FindGameObjectsWithTag("Player");
        foreach (var item in cokluobje)
        {
            item.GetComponent<AudioSource>().mute = true;

        }

        // FindGameObjectsWithTag kullanarak ayn� taga sahip birden fazla objeyi yakal�yoruz. s tak�s� kullanmasak denk geldi�i ilk objeyi al�r 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
