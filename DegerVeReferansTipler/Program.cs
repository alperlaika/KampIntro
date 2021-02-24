using System;
//Bu kısım çok önemli-Ara Konudur-
namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ??
            Console.WriteLine("sayi1:" +sayi1);
            Console.WriteLine("sayi2:" + sayi2);

            //30
            int[] sayilar1 = new int[] { 10, 20, 30 };//new heaapte yer oluştur demek 
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            //yukarıdaki şu şekilde okunur sayilar1 in referans numarasını sayilar2'nin referans numarasına eşitle 
            //yani sadeceisim değişikliği oluyor o da stackte heap değerleri değişmiyor şimdilik
            //sayilar1 de sayilar2 de sayilar 2 nin değerlerinin adresini gösterir
            //daha sonra sayilar2 nin ilk elemanına 999 atadığımız için sayilar1 de sayilar2 nin adresini tuttuğu için
            // sayilar2 nin ilk elemanındaki değeri gösterir atanmış haliyle.C deki pointer mantığı
            // eski sayilar1 arrayının elemenları boşta kaldı bu değerler kullanılmayacağı için .net deki çöp toplayıcısı bellekte atılacaktır 
            sayilar2[0] = 999;
            // sayilar2[0]??
            Console.WriteLine("sayilar2[0]:" +sayilar2[0]);
            //999

            // int,decimal,float,double,bool bunlar değer tiptir(sayısal görüntüdeler)
            //fakat array,class, interface  bunlar  ise referans tip olarak karşımıza çıkar(arrayın int vs olması önemli değil her şekil referanstır)
           

        }
    }
}
