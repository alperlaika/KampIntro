using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {

            //classları ikiye ayırıyoruz kullanım yöntemi olarak . 
            //Biri içerisinde özellik bulunduran Diğeri ise içersinde operasyon yani metotbarındıran class şeklinde
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //yukarıdaki ve aşağıdaki aynı şeyleri ifade eden farklı iki kullanımdır.

            Product product2 = new Product {Id=2,CategoryId=5,UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };
            //PascalCase  //camelCase
            // string       isim;   aşağıdaki bunun ggibi düşünülebilir  //case sensitive
            // ProductManager productManager;
            // stack         //heap
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

            //int ,double,bool... değer tip
            //diziler,class,abstract class,interface... referans tip

        }
    }
}
