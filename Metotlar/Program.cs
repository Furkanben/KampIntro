using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };


            //tpye-safe??
            foreach (Urun urun in urunler)//"urunler" adlı array'deki "Urun" türündeki her "urun" takma adlı öğe için aşağıdaki komutu çalıştır.
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----");
            }

            Console.WriteLine("---------Metotlar---------");

            //Instance oluşturma "sepetManager"
            //encapsulation**

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //ekleme düğmesinin olması istenen yere konur.
            sepetManager.Ekle(urun2);

            //YAPILMAMASI GEREKEN!
            //sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            //sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            //sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);
        }
    }
}