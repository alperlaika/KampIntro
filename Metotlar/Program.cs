using System;
//****///
//cs c# dosyası olduğunu gösteriyor

// DO NOT REPEAT YOURSELF---Clean Code--Best Practice
// temel yapılar classlardan oluşur
//classlar nesnelerin niteliklerini verir(açıklar)
//C# ta classların isimlerinin ilk harfi büyük olmalı(commention)
namespace Metotlar
{
    class Program
    {
        //Bir manav için e uygulama
        static void Main(string[] args)
        {
            //urunun tüm niteliklerini getirebiliriz.
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            //classlar bize kolaylık sağlar 

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };// string[] meyveler=new string[] {"elma","karpuz"} şeklinde yazılır array olarak string tipinde yazarsak
                         //aşağıdaki urun yerine x de yazsan olur //Urun ise verinin tipidir class(type safe(tip güvenliği))
            foreach (Urun urun in urunler)//in urunler dediğinde  urunler dizisindeki her bir elemanını kes 
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");
            }
            Console.WriteLine("----------------Metotlar-----------------");

            //classı çağıralım
            //instance -örnek
            SepetManager sepetManager = new SepetManager();
            //aşağıdaki şeklinde yazınca metotumuzu çağırıp içerisindeki nitelikleri alıyoruz
            sepetManager.Ekle(urun1);//herbiri farklı sayfa gibi düşünüp metot çağırıyoruz
            sepetManager.Ekle(urun2);//metot bana tekrar tekrar aynı şeyi kullanabilme imkanı verir.
                                     //sepete eklendi metotundaki değişimler sayfaya da yansır

            Console.WriteLine("-----------------");

            // class kullanılmadan yapılan işlem aşağıdakileri ama bu  yanlış bir kullanım
            // yönetici stok adetini girmek istediğinde metotun içindeki parametreyi de değiştirmek zorunda kalıyorsun
            //ekle2 metotunda değişim yapınca yani 4 parametresi olunca aşağıdak işlemler hata verir çünkü
            // kullanıcı diğerlerinin stağuna ihtiyacı olmamış olabilir ama bu durumda yine de bilmek orundayız stok sayısını
            // bu yüzden class yerine bu kullanım hatalı oluyor değişimler karşısında daha büyük sorunlara neden olduğu için
            // oysa class kısmında stok diye bir nitelik tanımladığımızda diğer sayfalarda hata vermez
            // eski halibu şekildeydi sepetManager.Ekle2("Armut", "Yesil Armut", 5);

            // buna encapsulation denir.Yani ayrı ayrı yazacağın ve bunun sonucunda düzensiz olacak bu yapıyı
            //bir düzen içerisine bir kapsülün içine koyuyoruz.Böylelikle daha düzenli kodlara sahip olmuş oluyoruz.
            sepetManager.Ekle2("Armut", "Yesil Armut", 5,45);
            sepetManager.Ekle2("Elma", "Yesil Elma", 2,2);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,5);




        }
    }
}
