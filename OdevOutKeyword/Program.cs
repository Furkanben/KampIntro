using System;

namespace OdevOutKeyword //OdevRefKeyword ÜZERİNDEN DEVAM!
{
    class Program
    {
        static void Main(string[] args)
        {
            //Add();
            //Add();
            //Add();
            //Add();
            //var result = Add2();

            int number1; //"out" kullanacağımız için "ref"teki gibi "number1" için değer tanımlamamıza gerek yok.
            int number2 = 100;
            var result2 = Add3(out number1, number2);//"out" eklendiği için number1 referans tipe dönüştü ve sonradan tanımlanan "30" değerini aldı. "out" olmasaydı number1 değer tip olup yukarıda değer tanımlanmadığı için boşta kalacaktı (hata).

            Console.WriteLine(result2);
            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added successfully!");
        }

        static int Add2(int number1 = 20, int number2 = 30)
        {
            var result = number1 + number2;
            return result;
        }
        //Eğer sabit rakam ile işlem yapılıyorsa değer tip ile tanımlanan sabit değer kullanılır ancak kullanım durumuna göre sabit rakam yerine değişen (örneğin müşteriye özgü faiz oranı) rakam ile işlem yapılıyorsa "out" keyword'ü ile referans tip kullanılır.("ref" gibi)
        static int Add3(out int number1, int number2)//"out" ile number1 takma adlı değer atanmayan değişken buraya alındı, burada değer tanımlandı.
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}