using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformStaticMethodlar : MonoBehaviour
{

    public Transform hedef1;
    public Transform hedef2;

    float baslang�c=0.5f;
    void Update()
    {
       

        Vector3 pos1 = new Vector3(1f, 2f, 3f);
        Vector3 pos2 = new Vector3(41f, 5f, 1f);
        //Debug.Log( Vector3.Max(pos1, pos2));
        //Verdi�imiz iki vekt�r�n x, y, z bile�enlerinden en b�y�k de�erleri alarak bize yeni bir Vector3 de�i�keni olu�turur.
        //Debug.Log(Vector3.Min(pos1, pos2));

        //Debug.Log(Vector3.Scale(pos1, pos2));
        //�ki verkt�r� �arp�p bize yeni bir vekt�r d�nd�r�r

        print(pos2 - pos1);
        //operat�rler. �ki vekt�r� c�kar�r
        print(pos2 + pos1);
        print(pos2 * 2f);
        print(pos2 / 2f);
        //Burda * ve / i�lemleri i�in farkl� method kullan�calak



        transform.position = Vector3.Lerp(hedef1.position, hedef2.position, (Time.time- baslang�c));
        //lerp iki vekt�r�n aras�nda do�rusal �izgi olusturur.

        //float fark= Vector3.Distance(hedef1.position , hedef2.position);
        //Debug.Log(fark);
        //Verilen iki Vector3 de�i�keni aras�ndaki mesafeyi elde etmemizi sa�lar.

        //Vector3 mesafe = hedef2.position - transform.position;
        //float angle = Vector3.Angle(mesafe, transform.forward);
        //Debug.Log(angle);
        //Verilen iki vector de�i�keni aras�ndaki a��y� float tipinde elde etmemizi sa�lar. Bu a��n�n alabilece�i maksimum de�er 180 derecedir olacakt�r.
    }
   
}
