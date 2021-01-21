using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //stack ve heap yapısı

            //deger tipler için
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //referans tipler için
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            //int, decimal, float, double, bool(1-0): değer tip (değer ataması yapılır)
            //array, class, interface: referans tip (adres ataması yapılır)

            //bellekteki alanlar stack --> değer tiplerin tanımlandığı yer ve heap --> referans tiplerin tanımlandığı yer
        }
    }
}
