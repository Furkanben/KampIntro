using System;

namespace Constructers
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id=1, FirstName = "Engin", LastName = "Demiroğ", City = "Ankara" };//This runs the default constructor (unwritten).
            //or
            Customer customer2 = new Customer(2, "Derin", "Demiroğ", "Ankara");//Paranthesis runs the constructor written below.


        }   


    }

    class Customer
    {
        //Constructors containing properties
        public Customer()//default constructor (written, beacuse below constructor overwrites)
        {

        }


        public Customer(int id, string firstName, string lastName, string city)//Constructor written (overwrites unwritten default constructor).
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
