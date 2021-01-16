using System;


namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety
            //DO NOT REPEAT YOURSELF!
            //Değer tutucu

            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320;
            double faizOrani = 1.4;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.55;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("+");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}