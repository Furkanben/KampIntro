using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2; //önceki satır geçersiz oldu, sayi1=30 oldu
            sayi2 = 65;
            //sayi1 ?? = 30 olur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999 olur

            //int, decimal, float, double, bool(1-0): değer tip (değer atıyorsun)
            //array, class, interface: referans tip (adres atıyorsun)

            //bellekteki alanlar stack (değer tiplerin tanımlandığı yer) ve heap (referans tiplerin tanımlandığı yer)

        }
    }
}