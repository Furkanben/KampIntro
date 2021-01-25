using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Customer//Properties of a customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //OR detailed (not useful) property definition

        private string _firstName;
        public string Firstname
        {
            get { return _firstName;}
            set { _firstName = value;}
        }
    }
}
