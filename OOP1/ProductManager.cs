using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager//ürün ile ilgili operasyonalar var demek-ekleme silme güncelleme vs
    { 
        public void Add(Product product )//(string ad)//metodun çağrılma şekli// Product türünde bir şey ver(encapsulation)
        {
            Console.WriteLine(product.ProductName + "Eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "Güncellendi.");
        }
    }
}
