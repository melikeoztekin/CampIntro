using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 123456;
            musteri1.Adi = "Melike";
            musteri1.Soyadi = "Öztekin";
            musteri1.Yas = 24;
            musteri1.Sehir = "Ankara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 112233;
            musteri2.Adi = "Kadriye";
            musteri2.Soyadi = "Çakmak";
            musteri2.Yas = 23;
            musteri2.Sehir = "Manisa";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            Console.WriteLine("MÜŞTERİ LİSTEMİZ AŞAĞIDA YER ALMAKTADIR.");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Sehir);
                Console.WriteLine("----------------");
            }
            MusteriManager musteriManager = new MusteriManager();
            Console.WriteLine("------Müşteri Ekleme Metodu-------");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            Console.WriteLine("------Müşteri Silme Metodu-------");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);
            Console.WriteLine("-------Müşteri Listeleme Metodu-------");
            musteriManager.MusteriListele(musteri1);
            musteriManager.MusteriListele(musteri2);
        }
    }
}
