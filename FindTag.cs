using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindTag : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject[] cokluobje;
    void Start()
    {
        GameObject.Find("cube").GetComponent<Getcomponent>().küp.name = "samet";
        GameObject.Find("Ana/Cocuk").GetComponent<Getcomponent>().küp.name = "samet";

        //Find methodu oyundaki tüm sahneler arasýnda arama yapar. Bu yüzden performans açýsýndan iyi olmadýðý için genelde kullanýlmaz.

        GameObject.FindWithTag("enemy");
        //Tag ile aramak daha performanslý

        transform.Find("Cocuk").GetComponent<AudioClip>().name = "xzx";
        //Daha performanslý.Child bulmanýn bir farklý yöntemi

        cokluobje= GameObject.FindGameObjectsWithTag("Player");
        foreach (var item in cokluobje)
        {
            item.GetComponent<AudioSource>().mute = true;

        }

        // FindGameObjectsWithTag kullanarak ayný taga sahip birden fazla objeyi yakalýyoruz. s takýsý kullanmasak denk geldiði ilk objeyi alýr 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
