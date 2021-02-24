using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelistirici Yetistirme Kampı";
            string kurs2 = "Programlamaya Baslangıc için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Phyton";

            Console.WriteLine("\n");
            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            /*Yukarıdaki gibi yapamayız çünkü yeri geliyor 200 kurs oluyor o yüzden yukarıdaki gibi yazmak yerine (dizi= array tanımıyoruz
            */
            /*------*/

            //şu demek ben bir dizi tanımlıyorum

            string[] kurslar = new string[] { "Yazılım Gelistirici Yetistirme Kampı", "Programlamaya Baslangıc için temel kurs", "Java" ,"Phyton","C++"};
            //for(int i=0; i<3; i++) ** 3 demek yanlış olur çünkü dinamik olarak kaç kur olduğunu bilmeme ihtimalimiz yüksektir.Bu yüzden kurslar.lenght dersek kaç tane kur olduğunu program tarafından buluruz.
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine("\n----");

                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\nfor bittiii\n");
            //foreach dizi temelli yapıları tek tek dönmemizi sağlar(dizilere uygulanır foreach) 
            //kurs bir alias i gibi düşün1.kurs 2.kurs vs.
            //in kurslar=kursları dolaş demek
            //foreach (var item in collection)

            foreach (string kurs in kurslar)
            {
                //for daha genel amaç için foreach dizi dolaşmak için kullanılır.
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\nSayfa Sonu -footer");
        }
    }
}
