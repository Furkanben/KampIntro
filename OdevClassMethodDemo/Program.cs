using System;

namespace OdevClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("---------Customer Credit Risk Information---------");

            var customerName = "Name";
            var customerBalance = "Balance";
            var customerCreditRisk = "Risk level";
            
            Customer customer1 = new Customer();
            customer1.Name = "Ayşe Kara";
            customer1.Balance = 300.00;
            customer1.CreditRisk = "Medium";

            Customer customer2 = new Customer();
            customer2.Name = "Murat Demir";
            customer2.Balance = 2300.00;
            customer2.CreditRisk = "Low";

            Customer customer3 = new Customer();
            customer3.Name = "Erşan Kuneri";
            customer3.Balance = 500000;
            customer3.CreditRisk = "Very low";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, };

            foreach (Customer customer in customers)
            {
                Console.WriteLine("---------Customer Details---------"); 
                Console.WriteLine(customerName + ": " + customer.Name);
                Console.WriteLine(customerBalance + ": " + customer.Balance);
                Console.WriteLine(customerCreditRisk + ": " + customer.CreditRisk);
                Console.WriteLine("\n");
            }

            Console.WriteLine("***End of the report***");

        }
    }
}
