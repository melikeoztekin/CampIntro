using System;

namespace GamePlatformDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Uye uye1 = new Uye();
            uye1.Id = 1;
            uye1.TcNo = "12345678910";
            uye1.DogumYili = 1996;
            uye1.Adi = "Melike";
            uye1.Soyadi = "Öztekin";

            Uye uye2 = new Uye();
            uye2.Id = 2;
            uye2.TcNo = "10111213141";
            uye2.DogumYili = 1975;
            uye2.Adi = "Umut";
            uye2.Soyadi = "Kayra";

            UyeManager uyeManager = new UyeManager();
            Console.WriteLine("-------Uye ekleme işlemi--------");
            uyeManager.UyeEkle(uye1);
            uyeManager.UyeEkle(uye2);
            Console.WriteLine(uye1.Adi + " " + uye1.Soyadi + " " + "adına üye kaydı yapıldı");
            Console.WriteLine(uye2.Adi + " " + uye2.Soyadi + " " + "adına üye kaydı yapıldı");

            Console.WriteLine("-------Uye güncelleme işlemi--------");
            uyeManager.UyeGuncelle(uye2);
            Console.WriteLine(uye2.Adi + " " + uye2.Soyadi + " " + "adına üye bilgisi güncellendi");

            Console.WriteLine("-------Uye silme işlemi--------");
            uyeManager.UyeSil(uye1);
            Console.WriteLine(uye1.Adi + " " + uye1.Soyadi + " " + "adına üye kaydı silindi");

            Console.WriteLine("-------Kampanya Ekleme işlemi-------");
            YuzdeElliCuzdanIndirimi yuzdeElliCuzdanIndirimi = new YuzdeElliCuzdanIndirimi();
            KampanyaManager kampanyaManager = new KampanyaManager();
            kampanyaManager.KampanyaEkle(yuzdeElliCuzdanIndirimi);
            yuzdeElliCuzdanIndirimi.KampanyaGoruntule();


            UrunSatis urunSatis1 = new UrunSatis();
            urunSatis1.UrunSatisId = 1;
            urunSatis1.UrunSatisFiyati = 20;

            UrunSatisManager urunSatisManager = new UrunSatisManager();
            urunSatisManager.UrunSatis(uye1, urunSatis1, yuzdeElliCuzdanIndirimi);



            Console.WriteLine("-------Kullanıcı kayıt oldu mu--------");
            UyeKayit uyeKayit = new UyeKayit();
            uyeKayit.KayitId = 1;
            uyeKayit.KayitYapildiMi = false;
            UyeKayitManager uyeKayitManager = new UyeKayitManager();
            IKayitYapildiMi kayitYapildiMi = new EDevletDogrulama();
            uyeKayitManager.KayitYap(uyeKayit, kayitYapildiMi);
        }
    }
}
