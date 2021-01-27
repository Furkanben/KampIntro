using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //abstract object, doesn't have a function alone
    interface IPerson//The operation to be implemented to all objects. IPerson contains common properties of Customer and Student.
    {
        int Id { get; set; }//Properties that Customer and Student classes must contain.Does not start with "public"
        int FirstName { get; set; }//Properties that Customer and Student classes must contain.Does not start with "public"
        int LastName { get; set; }//Properties that Customer and Student classes must contain.Does not start with "public"
    }
    //concrete object
    class Customer : IPerson//Customer (= person) is like a subset of IPerson
    {
        public int Id { get ; set ; }//"public" versions of the properties in the IPerson interface
        public int FirstName { get; set; }//"public" versions of the properties in the IPerson interface
        public int LastName { get; set; }//"public" versions of the properties in the IPerson interface
        public int CustomerAddress { get; set; }//customer specific property
        public int CustomerNumber { get; set; }//customer specific property

    }
    //concrete object
    class Student : IPerson//Student (= person) is like a subset of IPerson
    {
        public int Id { get; set; }//"public" versions of the properties in the IPerson interface
        public int FirstName { get; set; }//"public" versions of the properties in the IPerson interface
        public int LastName { get; set; }//"public" versions of the properties in the IPerson interface
        public int StudentNumber { get; set; }//student specific property
        public string Department { get; set; }//student specific property
    }
}