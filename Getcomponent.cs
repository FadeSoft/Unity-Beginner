using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Getcomponent : MonoBehaviour
{
    public GameObject küp;

    Collider colliderim;
    void Start()
    {
        colliderim = GetComponent<Collider>();
        colliderim.enabled = false;
        //Bu yöntem daha optimize. Deðiþken tanýmlar gibi colliderimi tanýmlýyorum. Sonra getcomponent ile collideri deðiþkenime atýyorum.
        //Herhangi bir iþlem yapmak istersem bir daha getcomponent yapýp sistemin o componenti bulmasýndan ziyade deðiþkeni kullanarak iþlem yapýyorum.




        //Component'e eriþebilir veya eriþip component özelliklerini deðiþtirebiliriz.
        GetComponent<BoxCollider>().enabled = true;
        küp.GetComponent<MeshRenderer>().enabled = false;
        küp.GetComponent<Collider>().isTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
