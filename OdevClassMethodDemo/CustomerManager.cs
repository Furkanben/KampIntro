using System;
using System.Collections.Generic;
using System.Text;

namespace OdevClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer.Name);
        }

        public void BalanceUpdate(Customer customer)
        {
            Console.WriteLine("Customer balance updated: " + customer.Name);
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.Name);
        }

    }
}
