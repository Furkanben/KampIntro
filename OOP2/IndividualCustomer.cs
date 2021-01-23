using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class IndividualCustomer:Customer//Inheritance - Meaning: IndividualCustomer is a Customer
    {
        public string TcKn { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}