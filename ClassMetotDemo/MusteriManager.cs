using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Sisteme Bilgileriniz Eklenmiştir. Teşekkürler " + musteri.Adi + " "+musteri.Soyadi);
        }
        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri listesine kaydınız başarı ile eklendi. " + musteri.Id + " " + musteri.Adi+" "+musteri.Soyadi+ " " + musteri.Yas + " " + musteri.Sehir);
        }
        public void MusteriSil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi+" "+musteri.Soyadi+" Müşteri kaydınız silindi.");
        }
    }
}
