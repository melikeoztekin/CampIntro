using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Burada operasyonlar tanımlayacağız
    //KonutKrediManager , TasitKrediManager , IhtiyacKrediManager classlarının ebeveyni
    interface IKrediManager 
    {
        void Hesapla();
        void BiseyYap();
    }
    //imzaları aynı olan yapılar için interface kullanılır
    //Okunurluğu artırmak için interfaceler I harfi ile başlar
    //eğer bir işlemde hesaplama işlemi yapılacak ama farklı şekillerde ele alınacaksa interfaceler kullanılır
    //interfaceler genel olarak operasyonel sistemlerde kullanılır
}
