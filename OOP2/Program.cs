using System;

namespace OOP2
{
    class Program
    {
        //referans tutucu olayını öğrenmek için bu projeyi yaptık
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Melike";
            musteri1.Soyadi = "Öztekin";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "23456";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "987654321";

            //GercekMusteri - TuzelMusteri 
            //Musteri çeşitleri - bunlar birbirine benzeyen iki farklı tiptir- asla birbirinin yerine kullanılamazlar.)
            //SOLID in L harfi "birbirine benziyor diye birbirinin yerine kullanma.!!

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //Biryerde new (ref.no) varsa bu bellekteki bir referans numarası demektir.
            //Musteri classı musteri3 ve musteri4 un referansını tutuyor.
            //Yani hem GercekMusteri hem de  TuzelMusteri referanslarını tutar.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);
        }
    }
}
