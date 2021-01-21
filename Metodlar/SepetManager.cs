using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Ürün Sepete Eklendi : "+urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat,int urunAdedi)
        {
            Console.WriteLine("Tebrikler. Ürün Sepete Eklendi : " + urunAdi);
        }
    }
}
