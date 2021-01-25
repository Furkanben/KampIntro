using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {   //Instantiating operations that will be defined in classes CustomerManager and ProductManager
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";//"set" block
            customer.LastName = "Demiroğ";

            //OR IN SHORT

            Customer customer2 = new Customer
            {
                Id = 2, City = "İstanbul", FirstName = "Derin", LastName = "Demiroğ" 
            };

            Console.WriteLine(customer2.FirstName);//"get" block


            Console.ReadLine();
        }
    }
}