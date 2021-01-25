using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformDemo
{
    class KampanyaManager
    {
        public void KampanyaEkle(IKampanya kampanya)
        {
            Console.WriteLine("kampanya eklendi");
        }
        public void KampanyaGuncelle(IKampanya kampanya)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
        public void KampanyaSil(IKampanya kampanya)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
