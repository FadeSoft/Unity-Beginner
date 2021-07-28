using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class methodislemler : MonoBehaviour
{

    private string ad = "samdt batman erzurum 25";
    private string ad2 = "    d  t  t";

    private int a = 45;



    void Start()
    {
        string[] parcala = ad.Split(' ');
        foreach (var item in parcala)
        {
            print(item);
        }
        //Boþluða denk geldin mi parçala...

        //print(ad.Substring(1,7));
        //birinci ve 7. indis arasýný yazdýr

        //print(ad.Substring(1));
        //Birinci indisten basla ve yazdýr


        //print(ad2.TrimStart().TrimEnd());
        //print(ad2.TrimStart());
        //print(ad2.TrimEnd());

        //print(ad2);
        //print(ad2.Trim());
        //Basýndaki ve sonundaki bosluklarý temizler.


        //print(ad.Replace(" ", "/"));
        //ilk parametreyi aratýr eðer varsa ikinci parametre ile deðiþtirir.


        //print(a.ToString());
        //Bazý deðerler(int) yazdýrýlamýyor. Bizde bu deðeri stringe çevir sonra yaz diyoruz.




        //string metin = "asdasdasd";
        //print(metin.Length);
        //print(metin.ToLower());
        //print(metin.ToUpper());
        // Metnin uzunluðunu gösterir, hepsini büyük veya küçük harfe çevirir.




        //if (ad.StartsWith("s"))
        //{
        //    print("evet");
        //}
        //else
        //{
        //    print("hayýr");
        //}

        //Büyük küçük harfe duyarlýdýr.

        //if (ad.EndsWith("t"))
        //{
        //    print("evet");
        //}
        //else
        //{
        //    print("hayýr");
        //}
        //Sonu ne ile bitmiþ

        //if (ad.Equals(ad2))
        //{
        //    print("evet");
        //}
        //else
        //{
        //    print("hayýr");
        //}
        //ad, ad2 ile ayný mý ?
        

        //string kopyalanan = (string) ad.Clone();
        //print(kopyalanan);

        //print(ad.GetType());
        //print(a.GetType());
        //Deðiþkenlerin tipini bu þekilde görebiliriz.
    }

    void Update()
    {

    }
}
