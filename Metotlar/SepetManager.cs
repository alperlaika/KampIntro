using System;
using System.Collections.Generic;
using System.Text;
//Bir classın sonunda manager servis dal dateAccess controller gibi ifadeleri 
//classta görürsek bunlar bir operasyon tutuyor demek
namespace Metotlar
{
    class SepetManager
    {
        //phytonda bunu def ile yapmıştık
        //Naming convention
        //syntax
        public void Ekle (Urun urun)//clasın imzası: void Ekle (Urun urun)
        {
            //sadece ekle kısmını çağırmam bir şey ifade etmiyor.Senin neyi eklemek istediğini
            //metota vermen lazım.Buna parametre denir 
            // public void Ekle (Urun(verinin tipi) urun(verinin ismi))Urun urun parametredir.

            //fonksiyon metot aynı şey
            // Console.WriteLine("Tebrikler .Sepete Eklendi"); string +  iki string yanyana koy demek
            Console.WriteLine("Tebrikler .Sepete Eklendi: " + urun.Adi);// burada urunun tümözelliğine erişebilirizama daha iyi görülmesi için bu şekilde yazıldı


         
        }
        //Birden fazla metotun olabilir
        //aşağıdaki kullanım hatalı
        public void Ekle2(string urunAdi,string aciklama ,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler .Sepete Eklendi: " + urunAdi);
        }
    }
}
