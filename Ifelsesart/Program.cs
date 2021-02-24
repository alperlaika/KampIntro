using System;

namespace Ifelsesart
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 320000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("azalış butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değismedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Kullanıcı Ayarları Butonu ");
            }
            else
            {
                Console.WriteLine("Giris Yap  Butonu ");
            }
            Console.WriteLine("\n");

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
