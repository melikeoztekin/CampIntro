using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformDemo
{
    class UrunSatisManager
    {
        public void UrunSatis(Oyuncu oyuncu, UrunSatis urunSatis, IKampanya kampanya)
        {
            Console.WriteLine(oyuncu.Adi);
            Console.WriteLine(oyuncu.Soyadi);
            Console.WriteLine(urunSatis.UrunSatisId);
            kampanya.KampanyaGoruntule();
        }
    }
}
