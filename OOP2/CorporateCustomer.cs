using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class CorporateCustomer:Customer//Inheritance - Meaning: CorporateCustomer is a Customer
    {
        public string CompanyName { get; set; }
        public string TaxNumber { get; set; }
    }
}
