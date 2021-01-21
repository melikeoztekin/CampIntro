using System;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);
            dortIslem.Topla(8, 9);
            //Topla işleminin ne yaptığı bilgisi DortIslem.cs den gelir
        }
    }
}
