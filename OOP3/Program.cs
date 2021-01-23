using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //polimorfizm
        //interface kullanımı - şablon kullanımı
        //interfaceler birbirinin alternatifi olan ama farklı kodları olan işlemler için kullanılır
        static void Main(string[] args)
        {
            //kullanılabilecek işlemler
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager esnafKredisiManager = new EsnafKredisiManager();

            //interface onu implament eden classın referansını tutabilir.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(esnafKredisiManager, new List<ILoggerService> {new DatabaseLoggerService(), new SmsLoggerService()}); 
            //BasvuruManager.cs deki Hesaplaya burdan seçilen classın bilgisi gider


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager };
            
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler); //listten seçilen kredileri basvurumanagerın kredionbilgilendirmeyap classı için da hesapla

            //SOLID --> O-Sisteme yeni özellik eklendiğinde mevcut kodlar bozulmaz!! (esnafkredisini sonradan ekliyoruz)
        }
    }
}
