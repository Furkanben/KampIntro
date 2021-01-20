using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; //2: Mobilya* (veri kaynağı değşebilir)
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 }; //Alternatif olarak böyle de yazılabilir)
            //Pascal Case (class)        //camelCase
            //Case sensitive yazım
            //EŞİTLİĞİN SOL TARAFI STACK, SAĞ TARAFI HEAP!!!
            ProductManager productManager = new ProductManager(); //Instance creation
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);//"Kamera" yazılır, çünkü ProductManager metodu içinde bunun adresine "Kamera" atanmış oldu.

            
            //int, double, bool.. değer tip
            //diziler, class, abstract class, interface... referans tip
            //ref out

        }
    }
}
