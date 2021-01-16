using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.urunKodu = 123456;
            urun1.kadinMi = true;
            urun1.urunAdi = "Çiçekli Elbise";
            urun1.urunRengi = "Mor";

            Product urun2 = new Product();
            urun2.urunKodu = 234567;
            urun2.kadinMi = false;
            urun2.urunAdi = "Kapüşonlu Hırka";
            urun2.urunRengi = "Siyah";

            Product urun3 = new Product();
            urun3.urunKodu = 345678;
            urun3.kadinMi = true;
            urun3.urunAdi = "Yüksek Bel Pantolon";
            urun3.urunRengi = "Kot Mavi";

            Product[] product = new Product[] { urun1, urun2, urun3 }; Console.WriteLine("-------for döngüsü--------");
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine(product[i].urunKodu + " - " + product[i].urunAdi + " - " + product[i].urunRengi);
            }

            Console.WriteLine("-------foreach döngüsü--------");
            foreach (var urun in product)
            {
                Console.WriteLine(urun.urunKodu + " - " + urun.urunAdi + " - " + urun.urunRengi);
            }

            Console.WriteLine("-------while döngüsü--------");
            int sayac = 0;
            while (sayac < product.Length)
            {
                Console.WriteLine(product[sayac].urunKodu + " - " + product[sayac].urunAdi + " - " + product[sayac].urunRengi);
                sayac++;
            }
            Console.WriteLine("---------------------------");
            Console.WriteLine("@mlkztkn saygılarla sunar.");
            Console.WriteLine("---------------------------");
        }
    }
    class Product
    {
        public int urunKodu { get; set; }
        public bool kadinMi { get; set; }
        public string urunAdi { get; set; }
        public string urunRengi { get; set; }
    }
}
