using System;

namespace TernaryOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kullaniciOturumu = false; //Burada durum manüel olarak false tanımlandı, get ile veri kaynağından alınacak.

            string ileti = kullaniciOturumu ? "Hoş geldiniz!" : "Oturum açın"; //Oturum durumu tespiti, oturum açıksa "Hoş geldiniz!", açık değilse "Oturum açın" çıktısı istendi.

            Console.WriteLine(ileti);
        }
    }
}