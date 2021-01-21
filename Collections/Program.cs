using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] {"Melike","Kadriye","Ceylan","Umut" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);
            //names = new string[5]; //Bu yöntemi yapmak listedeki diğer elemanları kaybetmeye sebep olur
            //names[4] = "Kayra"; //Yeni dizi elemanları [ , , , ,"Kayra"] olur
            //Console.WriteLine(names[4]); //Kayrayı burada döndürür
            //Console.WriteLine(names[0]); //Bunun çıktısı olarak boşluk gönderir

            List<string> names2 = new List<string> { "Melike", "Kadriye", "Ceylan", "Umut" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Kayra");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            
        }
    }
}
