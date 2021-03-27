using System;

namespace _5_HW1_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            Person[] persons = new Person[3]{ new Customer{FirstName = "Aytuğ"}, new Student{FirstName = "Çağatay"}, new Person{FirstName = "Caner"}};

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    interface IPerson
    {
        
    } 

    class Customer : Person,IPerson
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
