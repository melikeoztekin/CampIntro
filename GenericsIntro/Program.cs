using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>(); //string türünde bir liste 
            //MyList.cs de T yi string yapmış olduk
            isimler.Add("Melike");

            List<string> liste = new List<string>();
            Console.WriteLine(liste.Count);
        }
    }
}
