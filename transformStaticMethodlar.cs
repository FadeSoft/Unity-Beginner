using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformStaticMethodlar : MonoBehaviour
{

    public Transform hedef1;
    public Transform hedef2;

    float baslangýc=0.5f;
    void Update()
    {
       

        Vector3 pos1 = new Vector3(1f, 2f, 3f);
        Vector3 pos2 = new Vector3(41f, 5f, 1f);
        //Debug.Log( Vector3.Max(pos1, pos2));
        //Verdiðimiz iki vektörün x, y, z bileþenlerinden en büyük deðerleri alarak bize yeni bir Vector3 deðiþkeni oluþturur.
        //Debug.Log(Vector3.Min(pos1, pos2));

        //Debug.Log(Vector3.Scale(pos1, pos2));
        //Ýki verktörü çarpýp bize yeni bir vektör döndürür

        print(pos2 - pos1);
        //operatörler. Ýki vektörü cýkarýr
        print(pos2 + pos1);
        print(pos2 * 2f);
        print(pos2 / 2f);
        //Burda * ve / iþlemleri için farklý method kullanýcalak



        transform.position = Vector3.Lerp(hedef1.position, hedef2.position, (Time.time- baslangýc));
        //lerp iki vektörün arasýnda doðrusal çizgi olusturur.

        //float fark= Vector3.Distance(hedef1.position , hedef2.position);
        //Debug.Log(fark);
        //Verilen iki Vector3 deðiþkeni arasýndaki mesafeyi elde etmemizi saðlar.

        //Vector3 mesafe = hedef2.position - transform.position;
        //float angle = Vector3.Angle(mesafe, transform.forward);
        //Debug.Log(angle);
        //Verilen iki vector deðiþkeni arasýndaki açýyý float tipinde elde etmemizi saðlar. Bu açýnýn alabileceði maksimum deðer 180 derecedir olacaktýr.
    }
   
}
