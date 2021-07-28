using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformİslemleri : MonoBehaviour
{

    Vector3 pos1;
    Vector3 pos2;

    void Start()
    {
        //Vector2 a;// 2 boyut
        //Vector3 b;// 3 boyut
        //Vector4 c; // 4 boyut , gölgelendirme işlemlerinde kullanılır (shader)
        //Quaternion d;//

        Debug.Log(transform.position);
        Debug.Log(transform.rotation);
        Debug.Log(transform.localScale);

        //Objenin konumlarını ekrana yazdırdık. Ama rotationda istisnai bir durum mevcut. Bu şekilde yazdırınca 0 ların çıkacağını göreceksin
        //Rotasyon için ilerde başka bir method kullanacagız.

        pos1 = new Vector3(1f, 2f, 3f);
        pos2 = new Vector3(1f, 2f, 3f);
        //Vector3 tanımladık
    }

    private void Update()
    {
        //transform.Translate(new Vector3(0, 0, 10)*Time.deltaTime);

        if (Input.GetKey("w"))
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        if (Input.GetKey("a"))
            transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
        if (Input.GetKey("s"))
            transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime);
        if (Input.GetKey("d"))
            transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);

        //Debug.Log(Vector3.Magnitude(transform.position));
        //Objenin o anki uzunlugunu gösteriyor. Vektörün uzunluğunu hesaplar.

        //Debug.Log(Vector3.SqrMagnitude(transform.position));
        // objenin uzunlugunun karesını verir, daha performanslı normal magnitude ye göre


        //Translate methodu bir kere çalışır. Bu yüzden update e yazıyoruz.
        //Time.deltatime yazmamın sebebi her bir karede(frame) hareket etmesi.
        //Vector.one (1,1,1)
        //Vector.zero (0,0,0)

        if (Vector3.Equals(pos1, pos2)) //Burda vector3 ü yazmasanda olur
        {
            Debug.Log("evet aynı");
        }

        else
        {
            Debug.Log("Hayır aynı degıl");
        }

        if (pos1== pos2) //Bu daha kesin yöntem
        {
            Debug.Log("evet aynı");
        }

        else
        {
            Debug.Log("Hayır aynı degıl");
        }
    }
}
