using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //KrediManager dan inherit ettim
    //ampuldan interfacei çektim artık herkes kendi yapısını yazabilir.
    class KonutKrediManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //
            //
            Console.WriteLine("Konut Kredisi ödeme planı hesaplandı");
        }
    }
}
