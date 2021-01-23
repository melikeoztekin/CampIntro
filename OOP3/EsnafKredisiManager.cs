using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı.");
        }

        //SOLID - O harfi der ki sisteme sonradan eklenen özellikler var olan kodları bozmaz.
    }
}
