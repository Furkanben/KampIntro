using System;

namespace OdevRefKeyword //OdevMethods ÜZERİNDEN DEVAM!
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

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);//"ref" eklendiği için number1 referans tipe dönüştü ve sonradan tanımlanan "30" değerini aldı. "ref" olmasaydı number1 değer tip olup yukarıda tanımlanan 20 değerini alacaktı.

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
        //Eğer sabit rakam ile işlem yapılıyorsa değer tip ile tanımlanan sabit değer kullanılır ancak kullanım durumuna göre sabit rakam yerine değişen (örneğin müşteriye özgü faiz oranı) rakam ile işlem yapılıyorsa "ref" keyword'ü ile referans tip kullanılır.
        static int Add3(ref int number1, int number2)//"ref" ile 20 olan number1'ı buraya alıp metodun içinde 30'a dönüştürdük.
        {
            number1 = 30;
            return number1 + number2;
        }
    }
}
