using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin"); //<bunun içinde> tanımlanan türde veri girilmeli (burada string)

            Console.WriteLine(isimler.Length);

            isimler.Add("Kerem"); //<bunun içinde> tanımlanan türde veri girilmeli (burada string)

            Console.WriteLine(isimler.Length);

            Console.WriteLine("The end");
        }
    }
}
