using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //Örnek veriler
            string adi = "Kamil"; //string
            int yas = 32; //integer

            //CLASS
            Kurs kurs1 = new Kurs(); //Kurs tipinde (string, int, double gibi veri tipi içeren) birden çok property içeren bir Class olacak (aşağıda referans alınacak*).
            kurs1.KursAdi = "Yazılım Geliştirici Yetiştirme Kampı"; //Aşağıda string türünde KursAdi olarak tanımlanan Property
            kurs1.Egitmen = "Kamil";//Aşağıda string türünde Egitmen olarak tanımlanan Property'nin kaynağı
            kurs1.IzlenmeOrani = 45; //Aşağıda int türünde IzlenmeOrani olarak tanımlanan Property'nin kaynağı
            //CLASS
            Kurs kurs2 = new Kurs(); //Kurs tipinde (string, int, double gibi veri tipi içeren) birden çok property içeren bir Class olacak (aşağıda referans alınacak*).
            kurs2.KursAdi = "C#"; //Aşağıda string türünde KursAdi olarak tanımlanan Property'nin kaynağı
            kurs2.Egitmen = "Tayfun";//Aşağıda string türünde Egitmen olarak tanımlanan Property'nin kaynağı
            kurs2.IzlenmeOrani = 90; //Aşağıda int türünde IzlenmeOrani olarak tanımlanan Property'nin kaynağı

            //CLASS
            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Yerelleştirme";
            kurs3.Egitmen = "Furkan Bolatkale";
            kurs3.IzlenmeOrani = 0;

            //Console.WriteLine(kurs1.KursAdi + "-" + kurs1.Egitmen + "-" + "%" + kurs1.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };//"kurslar" adlı "Kurs" sınıfını (class) içeren yeni (new) bir dizi (array, yani []) tanımlandı, yeni kurslar buraya eklenir.
            foreach (Kurs kurs in kurslar) //Kurs[] dizi tipindeki "kurslar" adlı collection içinde her Kurs class'ındaki "kurs" aliaslı öğe için komut yürütülecek.
            {
                Console.WriteLine(kurs.KursAdi + " - " + kurs.Egitmen);//Döngü için yürütülecek komut; yukarıda tanımlanan her Class için seçilen property'ler (kurs.KursAdi + " - " + kurs.Egitmen) listesi yazdırılır.
            }
        }
    }

    class Kurs //Aşağıdaki Property'leri içeren bir Class tanımladık.*
    {
        public string KursAdi { get; set; } //Property (string)

        public string Egitmen { get; set; } //Property (string)

        public int IzlenmeOrani { get; set; } //Property (integer)
    }
}