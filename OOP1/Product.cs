using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet hazır kodlar demek ... olan
    class Product //Entity
    {
        public int Id { get; set; }//primary key
        public int CategoryId { get; set; }//foreign key:2.sıraya yazmak kod okunurluğu açısından daha verimlidir
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }// ürünün birim fiyatı
        public int UnitsInStock { get; set; }// ürünün stok adeti
    }
    //eklemek silmek güncellemek listelemek gibi operasyonşara CRUD(CreateReadUpdateDelete) operasyonları deriz.
}
