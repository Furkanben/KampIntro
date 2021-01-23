using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Credit payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
