using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T> //T = optional ancak T genel yazım
    {
        T[] items;
        //constructer
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) //Yukarıda T olarak tanımlanan tür (string, int vs. olabilir)
        {
            T[] tempArray = items;//Öğeler tempArray'e tutturuldu.
            items = new T[items.Length+1]; //Dizinin şu anki değeri (0) + 1 denmiş oldu.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//tempArray'e tutturulan öğeler geri items'a alındı, items eski değerlerini aldı yani.
            }

            items[items.Length - 1] = item;//Eklemek için yer açılan öğe eklendi.

        }

        public int Length
        {
            get { return items.Length;}
        }
    }
}
