using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrayler sizin oluşturduğunuz sınırda kalır
            //sonradan bu sınırlara eleman ekleyemezsiniz
            //new ile yeni alan açarsak eski alandaki bazı değerleri kaybedebiliriz.
            //bundan dolayı genellikle array kullanmayız onun yerine koleksiyonları kullanırız 
            //böylelikle yukarıda bahsettiğim sorunlarla karşılaşmamış oluruz

            //string[] isimler = new string[] { "Ufuk", "Mahmut", "Bilal", "Özgür", "Eyüp", "İsmet", "Onur" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[5]);
            //Console.WriteLine(isimler[6]);

            /*  List<string> isimler2 = new List<string> { }; //bu şekilde de kullanılabilir
              isimler2.Add("Ufuk");*/

            List<string> isimler2 = new List<string> { "Özgür", "Eyüp", "Kerem", "Onur" };
            // <string> kısmında sadece string değil int ,boolean hatta bir class dahil her şeyi koyabiliriz.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine( "----------");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            


        }
    }
}
