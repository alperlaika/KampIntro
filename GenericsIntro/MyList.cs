using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    // Generic class demek özel bir üzerinde çalışacağımız anlamına gelir .T type tan geliyor T yerine A yazsakta olur.
    //Kısacası bu şu demek  ben MyList'imde T ile çalışacağım.
    class MyList<T>
    {
        //public void Add(string item) bu şekilde dediğimizde kullanıcı yalnızca string girebilir(string ile çalışmak zorunda
        //Ama ben istiyorum ki  benim çalışacağım tipi o an programcının seçtiği istediği tip olsun
        //işte bunun ifade ettiği sey T'dir.Yani ben sana T olarak ne verirsem istediğim elemanın türü de odur.

        T[] items; //demekki benim T[] items araryimi classa new'lediğimde oluşturmam gerekiyor.yani 0 elemanlı bir dizi oluşturmamız gerekiyor

        //ctor yazıp iki kere üst üste tab a bas buna constructor denir
        //aslında bir metotdur.class ismi ile aynıdır.Sen yukarıdaki classı bir yerde newlersen constructor anında çalışır
         //başlangıçta çalışır
        public MyList()//default otomatik çalışır
        {
            //classı newlediğimiz anda arrayı 0'ladık ve arrayı oluşturduk ve 0 elemanlı olarak verdik
            items = new T[0];
        } 

        //string[] items; bu şekilde kullanmam doğru değil string yerine T olmalıydı
        // Bunu methodun dışına yazmamımın nedeni public olması.Çünkü zaten classın içinde ve ben bunu tüm methodlardan erişmek istiyorum
        public void Add(T item)
        {
            /* items[1] diyemem çünkü 0 elemanlı benim dizimin sayısını bir artırmam gerek aşağıdaki gibi
            items = new T[items.Length + 1];//dizinin eleman sayısını bir artırıyor
             burada da şöyle bir sorun bulunmaktadır. bir eleman eklenince sayı artacak
             ama bir daha eklemek istediğimizde new olduğu için eskisini almayacak.referans numarası uçmuş oldu
              o yüzden o referansı birine tutturmamız lazım
             onun için t türünde gecici bir dizi atamamız gerek
            */
            T[] tempArray = items;//geçici dizinn referansı itemın referansıdır(onu tutuyor)"
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
        }
    }
}
