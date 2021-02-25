using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            // list kullanmak için using System.Collections.Generic; bu ifadeyi yukarıda dahil etmemiz gerekir.
            // MyList isimler = new MyList(); bu şekilde yazmamız hataya neden olur çünkü bu class bir generictir.Doğru kullanım aşağıdaki gibidir.
            // MyList<string>: string listesi demektir

            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");

            //Listenin countı diye bir şey var eleman sayısı demek biz eleman sayısını vermedik ama arrayde eleman sayısını
            //vermemiz gerekiyordu ve eleman sayısı verilmediğinde hata veriyordu ama aşağıdakinde ise hata vermedğini görürüz eleman sayısı verilmediği halde
            //çünkü list aslında arka planda bir arrayı yönetiyor
            //yani aşağıda : liste'yi oluşturduk ve eleman sayısını count yardımıyla sorduk
            List<string> liste = new List<string>();// burada bellekte referans oluşturuyoruz.Bir adres değeri al demek
            Console.WriteLine(liste.Count);
            Console.WriteLine("Hello World!");
        }
    }
}
