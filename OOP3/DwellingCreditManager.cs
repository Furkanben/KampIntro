using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DwellingCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Dwelling Credit payment plan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
