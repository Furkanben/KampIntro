﻿using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> cities = new List<string>();            
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");
            cities.Add("Ankara");            
            Console.WriteLine(cities.Count);

            MyList<string> cities2 = new MyList<string>();// Type int = Type T defined in las MyList below.
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            cities2.Add("Ankara");
            Console.WriteLine(cities2.Count);
        }
    }

    class MyList<T>//Generic class created (T is the variable Type)
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }

        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item; 
        }

        public int Count
        {
            get { return _array.Length; }
        }
    }
}