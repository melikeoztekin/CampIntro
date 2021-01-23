using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class Musteri
    {
        //classların içerisinde özellik ve 
        //özellik olan yerde operasyon olmaz operasyon olan yerde özellik olmaz


        //GercekMusteri ve TuzelMusteri Musteri de ortak olan alanlar
        //Musteri artık GercekMusteri ve TuzelMusteri nin ebeveynidir
        public int Id { get; set; }
        public string MusteriNo { get; set; }


        //eğer sayı olan verilerle işlem yapılmıyorsa tcno gibi bunu sayısal olmak yerine metinsel tanımlamak daha iyi olur.
        // ******Eğer ki bir nesnede bir değeri kullanmak zorunda değilsen burada soyutlama hatası vardır 
    }
}
