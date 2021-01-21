using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet-->Kod kalıbını direkt oluşturan durumun adı- 2 defa tab yap
    class Product
    {
        public int Id { get; set; } 
        public int CategoryId { get; set; } //referans anahtar olarak kullanılır.
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }

        //CRUD --> Creat,Read,Update,Delete
    }
}
