using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) //İşlem tanımlandı (işlemin uygulanacağı parametre)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi. : " + urun.Adi); //Tanımlanan işlem yürütüldü.
        }


        //açık hali ama yazma!
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler! Sepete eklendi. : " + urunAdi);
        }
    }
}