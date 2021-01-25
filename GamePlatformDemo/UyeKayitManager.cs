using System;
using System.Collections.Generic;
using System.Text;

namespace GamePlatformDemo
{
    class UyeKayitManager
    {
        public void KayitYap(UyeKayit uyeKayit, IKayitYapildiMi kayitYapildiMi)
        {
            Console.WriteLine("Uye Kaydedildi");
        }
        public void KaydiGuncelle(UyeKayit uyeKayit)
        {
            Console.WriteLine("Uye Kaydi Güncellendi");
        }
        public void KaydiSil(UyeKayit uyeKayit)
        {
            Console.WriteLine("Uye kaydi silindi");
        }
    }
}
