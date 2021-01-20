using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        //constructor - bir arrayin new yapılma durumu
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //T : sen bana ne tip verirsen ben o tip ile çalışacağım
        {
            T[] tempArray = items;
            items = new T[items.Length+1]; //dizinin eleman sayısını bir arttırır
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }
    }
}
