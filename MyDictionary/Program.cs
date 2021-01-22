using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string, double, int> identity = new MyDictionary<int, string, double, int>();
            identity.Add(123, "Melike Öztekin", 1.63, 46);
            identity.Add(234, "Kadriye Çakmak", 1.58, 50);
            identity.Add(345, "Ceylan Çokadar", 1.53, 48);
            identity.Add(456, "Umut Kayra", 1.23, 27);

            Console.WriteLine("Identity length = " + identity.Length);

            Console.WriteLine("--------Identity Numbers--------");
            foreach (var number in identity.Tnumber)
            {
                Console.WriteLine(+number);
            }

            Console.WriteLine("--------Identity Names----------");
            foreach (var name in identity.Tname)
            {
                Console.WriteLine(name);
            }
            
            Console.WriteLine("--------Identity Sizes----------");
            foreach (var size in identity.Tsize)
            {
                Console.WriteLine(size);
            }
            
            Console.WriteLine("--------Identity Weights----------");
            foreach (var weight in identity.Tweight)
            {
                Console.WriteLine(weight);
            }
        }
    }
}
