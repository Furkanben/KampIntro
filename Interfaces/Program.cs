using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", CustomerAddress = "Ankara" });
            manager.Add(new Student { Id = 1, FirstName = "Derin", LastName = "Demiroğ", StudentNumber = "12345" });
        }
    }
    //abstract object, doesn't have a function alone
    interface IPerson//The operation to be implemented to all objects. IPerson contains common properties of Customer and Student.
    {
        int Id { get; set; }//Properties that Customer and Student classes must contain.Does not start with "public"
        string FirstName { get; set; }//Properties that Customer and Student classes must contain.Does not start with "public"
        string LastName { get; set; }//Properties that Customer and Student classes must contain.Does not start with "public"
    }
    //concrete object
    class Customer : IPerson//Customer (= person) is like a subset of IPerson
    {
        public int Id { get ; set ; }//"public" versions of the properties in the IPerson interface
        public string FirstName { get; set; }//"public" versions of the properties in the IPerson interface
        public string LastName { get; set; }//"public" versions of the properties in the IPerson interface
        public string CustomerAddress { get; set; }//customer specific property
        public string CustomerNumber { get; set; }//customer specific property

    }
    //concrete object
    class Student : IPerson//Student (= person) is like a subset of IPerson
    {
        public int Id { get; set; }//"public" versions of the properties in the IPerson interface
        public string FirstName { get; set; }//"public" versions of the properties in the IPerson interface
        public string LastName { get; set; }//"public" versions of the properties in the IPerson interface
        public string StudentNumber { get; set; }//student specific property
        public string Department { get; set; }//student specific property
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }      
    }
}