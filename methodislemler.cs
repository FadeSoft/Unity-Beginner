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
        //Bo�lu�a denk geldin mi par�ala...

        //print(ad.Substring(1,7));
        //birinci ve 7. indis aras�n� yazd�r

        //print(ad.Substring(1));
        //Birinci indisten basla ve yazd�r


        //print(ad2.TrimStart().TrimEnd());
        //print(ad2.TrimStart());
        //print(ad2.TrimEnd());

        //print(ad2);
        //print(ad2.Trim());
        //Bas�ndaki ve sonundaki bosluklar� temizler.


        //print(ad.Replace(" ", "/"));
        //ilk parametreyi arat�r e�er varsa ikinci parametre ile de�i�tirir.


        //print(a.ToString());
        //Baz� de�erler(int) yazd�r�lam�yor. Bizde bu de�eri stringe �evir sonra yaz diyoruz.




        //string metin = "asdasdasd";
        //print(metin.Length);
        //print(metin.ToLower());
        //print(metin.ToUpper());
        // Metnin uzunlu�unu g�sterir, hepsini b�y�k veya k���k harfe �evirir.




        //if (ad.StartsWith("s"))
        //{
        //    print("evet");
        //}
        //else
        //{
        //    print("hay�r");
        //}

        //B�y�k k���k harfe duyarl�d�r.

        //if (ad.EndsWith("t"))
        //{
        //    print("evet");
        //}
        //else
        //{
        //    print("hay�r");
        //}
        //Sonu ne ile bitmi�

        //if (ad.Equals(ad2))
        //{
        //    print("evet");
        //}
        //else
        //{
        //    print("hay�r");
        //}
        //ad, ad2 ile ayn� m� ?
        

        //string kopyalanan = (string) ad.Clone();
        //print(kopyalanan);

        //print(ad.GetType());
        //print(a.GetType());
        //De�i�kenlerin tipini bu �ekilde g�rebiliriz.
    }

    void Update()
    {

    }
}
