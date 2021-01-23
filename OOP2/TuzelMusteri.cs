using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate - Tüzül Müşteri İng
    //miras - inheritance
    //TuzelMusteri bir Musteri classıdır demek
    //Musteri de olan özellikler GercekMusteri de de TuzelMusteri de de vardır demektir.
    class TuzelMusteri :Musteri
    {
        public string VergiNo { get; set; }
        public string SirketAdi { get; set; }
    }
}
