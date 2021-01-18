using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string student1 = "Metin";
            //string student2 = "Ali";
            //string student3 = "Feyyaz";
            //Bu şekilde tek tek yazmak yerine Array tanımlanır:
            //string[] students = new string[3];
            //students[0] = "Metin"; //students adlı array'in sıfırıncı (ilk) öğesi Metin.
            //students[1] = "Ali"; //students adlı array'in 1. öğesi (0'dan başladığı için aslında ikinci) öğesi Ali.
            //students[2] = "Feyyaz"; //students adlı array'in 2. (0'dan başladığı için aslında üçüncü) öğesi MetiFeyyaz.

            //ANCAK BUNUN EN KOLAY YOLU:

            string[] students = new[] { "Metin", "Ali", "Feyyaz" }; //Burada {} içine isteğe göre öğe eklenebilir (dinamik). NOT: new[] ifadesi çıkarılabilir (string[] students = { "Metin", "Ali", "Feyyaz" }.

            foreach (var student in students) //students adlı string array içinde her student takma adlı öğe (Metin, Ali, Feyyaz) için dönülmesi tanımlandı.
            {
                Console.WriteLine(student);//Her dönüşte sıradaki student takma adlı öğe yazdırılır.
            }
        }
    }
}
