using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformDemo
{
    class UyeManager
    {
        public void UyeEkle(Oyuncu oyuncu)
        {
            Console.WriteLine("Yeni oyuncu bilgileri eklendi.");
        }
        public void UyeGuncelle(Oyuncu oyuncu)
        {
            Console.WriteLine("Bilgileriniz başarıyla güncellendi.");
        }
        public void UyeSil(Oyuncu oyuncu)
        {
            Console.WriteLine("Oyuncu bilgileri silindi.");
        }

        
    }
}
