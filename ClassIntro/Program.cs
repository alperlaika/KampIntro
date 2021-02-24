using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            //bir kurs değişkeni tanımlamak istediğinde aşağıdaki gibi tanımlarsın 
            Kurs kurs1=new Kurs();
            //kurs1'in içine aşağıdaki değerleri atıyoruz class yardımıyla
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.izlenmeOrani = 69;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.izlenmeOrani = 55;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Phyton";
            kurs3.Egitmen = "Engin Mertoğlu";
            kurs3.izlenmeOrani = 695;

            Kurs kurs4 = new Kurs();
            kurs4.kursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.izlenmeOrani = 100;
            // gerçek hayatta da e ticarette sen ürün bilgilerini class yardımıyla girip yazarsın

            //Console.WriteLine(kurs1.kursAdi +" : "+kurs1.Egitmen);

            //bu kursları bir dizide tanımlarsak kkursunun veri tipi ne olur? cevap aşağıda

            // Kurs[] kurslar = new Kurs[];// yaniiçinde class Kurs nesnesini barındıran bir kurs tanımladık

            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};//önceden string tutuyorduk şimdi kurs objesini(nesnesini) tutuyorum
            foreach (var kurs in kurslar)
            {
                Console.WriteLine("\n-----*------");
                //  Console.WriteLine(kurs.kursAdi);
                //  Console.WriteLine(kurs.kursAdi + "  " + kurs.Egitmen +"  "+ kurs.izlenmeOrani);
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen);

            }


            Console.WriteLine("\nHello World!");
        }
    }

    class Kurs
    {
        //prop ile getiriyoruz.prop properties den gelir özellikllerini verir
         public string kursAdi { get; set; }
        public string Egitmen { get; set; }
        public int izlenmeOrani { get; set; }
    }
}   //public int MyProperty { get; set; }
    
