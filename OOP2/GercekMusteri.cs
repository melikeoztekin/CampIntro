using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Indivisual - Gerçek Müşteri İng
    //miras - inheritance
    //GercekMusteri bir Musteri classıdır demek
    //Musteride olan özellikler GercekMusteri de de TuzelMusteri de de vardır demektir.
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        
    }
}
