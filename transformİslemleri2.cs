using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformİslemleri2 : MonoBehaviour
{
    public Transform hedef;
    public Transform hedef2;
    public Transform parent;
    public GameObject child;
    
    private void Start()
    {
        //child.transform.SetParent(parent,false);
        //child objesi yap ama child objesinin pozisyonunu bozma

        //child.transform.SetParent(parent);
        child.transform.parent = transform;

        //child gameobjesini parant transformunun childobjesi yaptık

        //GameObject arama = transform.Find("GameObject").gameObject;
        //arama.name = "değiştirdim aq";
        //arama.GetComponent<CharacterController>().enabled = false;

        //Debug.Log(transform.childCount);
        //Bu scriptin oldugu objenin kaç cocugu var

        //Debug.Log(transform.hierarchyCount);
        //ebeveyn dahil kaç obje var

        //print(hedef.transform.localPosition);
        //print(hedef.transform.localRotation);
        //print(hedef.transform.localScale);
        //cocuk objenin pozisyonlarını bu şekilde alırım. Local dememin sebebi cocuk objenın pozisyonunu alacak olmam ana objenın deıl

        //transform.position = new Vector3(1, 2, 3);
        //transform.position = new Vector3(transform.position.x, 2f, 8f);
    }


    private void Update()
    {
        transform.LookAt(hedef,Vector3.left);

        transform.LookAt(hedef);
        // hedefi takip eder

        //transform.Translate(Vector3.forward);
        //transform.Translate(transform.forward);
        //Hareket ettirmek için illa vector e gerek yok.
        //transform.Translate(transform.up * Time.deltaTime * 2f);
        //Delta time yi daha stabil hareket etsin diye ekledim her karede bir. 2f ise hız gibi düşünülebilir.

        //transform.Rotate(new Vector3(1, 2, 10),Space.World);
        //World boşlukta döner gibi. Fizik kanunlarını baz alır. Daha derli toplu olur self e göre
        //transform.Rotate(new Vector3(1, 2, 10), Space.Self);
        //Self dönerken kendini baz alır.
    }
}
