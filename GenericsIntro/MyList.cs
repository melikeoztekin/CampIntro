using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T = optional ancak T genel yazım
    {
        T[] items;
        //constructor - bir arrayin new yapılma durumu
        public MyList() //class ilk olarak burada çalışacak
        {
            items = new T[0];
        }
        public void Add(T item) //T : sen bana ne tip verirsen ben o tip ile çalışacağım
                                //Yukarıda T olarak tanımlanan tür (string, int vs. olabilir)
        {
            T[] tempArray = items; //Ögeler tempArray'e sabitlenir.
            items = new T[items.Length+1]; //dizinin eleman sayısını bir arttırır
            for (int i = 0; i < tempArray.Length; i++) //Dizinin şu anki uzunluğu (0) + 1 denmiş oldu.
            {
                items[i] = tempArray[i]; //tempArray'e sabitlenen ögeler tekrar items a çekildi, items eski değerlerini aldı.
            }
            items[items.Length - 1] = item; //Eklemek için yer açılan öge eklendi.

        }
    }
}
