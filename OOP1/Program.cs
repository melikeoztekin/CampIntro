using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //Mesela mobilya kategorisinin Idsi 2 olsun
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;
            
            //product1 ve product2 de dizi elemanlarına iki farklı atama şekli gösterilmiştir

            Product product2 = new Product { Id=2,CategoryId=5, UnitsInStock=5,ProductName="Kalem",UnitPrice=35 };
            
            //EŞİTLİĞİN SOL TARAFI STACK<---->SAĞ TARAFI HEAP
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

            //classlarda pascal case (kelimenin baş harfi büyük) 
            //diğer tiplerde camel case(baş kelimenin harfi küçük diğeri büyük ---degerTip gibi)
            //c# case sensitive




            //int, double, bool.... değer tip
            //diziler,class,abstract class, interface.... referans tip
            //ref out
        }
    }
}
