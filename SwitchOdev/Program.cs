using System;

namespace SwitchOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your language");

            string language = "Deutsch"; //Burada dil manüel olarak yazıldı, dropdown menüden seçilebilir.
            switch (language) //İşlevin temeli olan koşulu tanımladım, çıktı "language" temelinde olacak.
            {
                case "Turkce":
                    Console.WriteLine("Hoş geldiniz!"); //Dil Türkçe olduğunda çıktı Türkçe karşılama metni olacak.
                    break;
                case "English":
                    Console.WriteLine("Welcome!"); //Dil İngilizce olduğunda çıktı İngilizce karşılama metni olacak.
                    break;
                case "Deutsch":
                    Console.WriteLine("Wilkommen!"); //Dil Almanca olduğunda çıktı Almanca karşılama metni olacak.
                    break;
                case "Francais":
                    Console.WriteLine("Bienvenue!"); //Dil Fransızca olduğunda çıktı Fransızca karşılama metni olacak.
                    break;
                default:
                    Console.WriteLine("Language not selected!"); // Dil seçilmemesi durumunda çıktı, dilin seçilmediğini belirtecek.
                    break;
            }
        }
    }
}