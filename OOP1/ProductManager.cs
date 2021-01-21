using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) //(string ad) olarakda kullanılabilirdi. Product classından product isimli bellek adresi tutan veriyi isteriz.
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        //public int topla(int sayi1, int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}
        //public void topla2(int sayi1, int sayi2)
        //{
        //    Console.WriteLine(sayi1 + sayi2);
        //}
    }
}
