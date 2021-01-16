using System;

namespace OdevMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(); //Aşağıda tanımlanan "Console.WriteLine("Added successfully!");" komutunu yürütmek için yazılan kod.
            Add(); //Aşağıda tanımlanan "Console.WriteLine("Added successfully!");" komutunu yürütmek için yazılan kod.
            Add(); //Aşağıda tanımlanan "Console.WriteLine("Added successfully!");" komutunu yürütmek için yazılan kod.
            Add(); //Aşağıda tanımlanan "Console.WriteLine("Added successfully!");" komutunu yürütmek için yazılan kod.
            var result = Add2(25, 35); //Aşağıda yazılan "return number1 + number2" komutunda kullanılacak "number1" ve "number2" parametrelerinin değerleri,
            var result1 = Add3(40); //Üst satırdaki yöntemde bir değer varsayılan olarak atandığında kullanılan komut. (örn. KDV oranı)
            Console.WriteLine(result); //Yukarıda "result" olarak tanımlanan değişken içindeki integer'ların toplamının çıktısı alınır.
            Console.WriteLine(result1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added successfully!"); //Yukarıda "Add" komutu yürütüldüğünde alınacak çıktı.
        }

        static int Add2(int number1, int number2) //Add2 adlı işlemde number1 ve number2 adlı parametrelerin kullanılacağı tanımlandı. Aşağıda tanımlanan çıktı "int" tipinde olacağı için "static int" yazıldı.
        {
            var result = number1 + number2; //return yerine "var result" yazılarak bir değişken tanımlanabilir, sonrasında "return result" komutuyla bu sonuç döndürülebilir.
            return result;

            //Alternatif yazım:
            //return number1 + number2;            
        }

        //!!!Default değer tanımlama!!!
        static int Add3(int number1, int number2=30) //Yukarıda "Add3()" içine önceki değer(ler)i girmek yeterli, 30 olarak tanımlanan varsayılan değer işleme otomatik eklenir.
        {
            var result1 = number1 + number2;
            return result1;            
        }
    }
}