using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Furkan";
            int yas = 32;

            Kurs kurs1=new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Kamil";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Faruk";
            kurs3.IzlenmeOrani = 95;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen + "-" + kurs.IzlenmeOrani);
            }        
        }
    }

    class Kurs //object?
    {
        public string KursAdi { get; set; } //property
        public string Egitmen { get; set; } //property
        public int İzlenmeOrani { get; set; } //property
        public int IzlenmeOrani { get; internal set; } //property
    }
}