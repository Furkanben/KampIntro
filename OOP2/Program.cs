using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNumber = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.TcKn = "11111111111";

            //Kodlama.io

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNumber = "542321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNumber = "1234567890";

            //Natural - Legal: Their properties SHOULD NOT be defined in the same class!!!

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            

        }
    }
}
