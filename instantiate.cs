using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour
{

    public GameObject dogacakObje;
    public GameObject obje;

    public Transform anaobje;

    void Start()
    {
        StartCoroutine(Deneme());


        //GameObject obj=  Instantiate(dogacakObje, new Vector3(transform.position.x, 5, 5), Quaternion.identity);
        //obj.GetComponent<BoxCollider>().enabled = false;
        //obj.transform.SetParent(transform);

        //Instantiate(dogacakObje, new Vector3(transform.position.x, 5, 5), Quaternion.identity);

        //Instantiate(dogacakObje, new Vector3(5,5,5), Quaternion.identity);

        //Instantiate(dogacakObje, obje.transform.position, Quaternion.identity);

        //Instantiate(dogacakObje, transform.position,Quaternion.identity);

        //Instantiate(dogacakObje, transform.position, transform.rotation);

        //Instantiate(dogacakObje, transform);
        //Scriptin oldugu objenin cocuk objesi olarak alt�na atar

        // Instantiate(dogacakObje,anaobje);
        //Anaobje objesinin transformunda spanwlan�r

        //Instantiate(dogacakObje);
        //Objenin kendi transformuna g�re  olusturur.


    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Deneme()
    {
        Instantiate(dogacakObje, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(4f);
        Start();

    }
}
