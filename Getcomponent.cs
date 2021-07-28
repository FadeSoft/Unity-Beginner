using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getcomponent : MonoBehaviour
{
    public GameObject k�p;

    Collider colliderim;
    void Start()
    {
        colliderim = GetComponent<Collider>();
        colliderim.enabled = false;
        //Bu y�ntem daha optimize. De�i�ken tan�mlar gibi colliderimi tan�ml�yorum. Sonra getcomponent ile collideri de�i�kenime at�yorum.
        //Herhangi bir i�lem yapmak istersem bir daha getcomponent yap�p sistemin o componenti bulmas�ndan ziyade de�i�keni kullanarak i�lem yap�yorum.




        //Component'e eri�ebilir veya eri�ip component �zelliklerini de�i�tirebiliriz.
        GetComponent<BoxCollider>().enabled = true;
        k�p.GetComponent<MeshRenderer>().enabled = false;
        k�p.GetComponent<Collider>().isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
