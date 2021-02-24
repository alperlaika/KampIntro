using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //class sayesinde nesne ile ilgili birden fazla özellikl(nitelik) tanımlayabiliriz.
    class Urun
    {
     //Property-Özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        // sadece stok eklediğimizde sayfalarda sorun çıkmaz
        public int StokAdedi { get; set; }
    }
}
