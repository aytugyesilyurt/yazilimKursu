using System;

namespace _5_HW1_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3] { new OracleServerCustomerDal(), new SqlServerCustomerDal(), new MySqlServerCustomerDal()};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            personManager.Add(new Customer {Id = 1, FirstName = "Aytuğ", LastName = "YEŞİLYURT", Adress = "İzmir"});

            Student student1 = new Student() {Id = 1, FirstName = "Çağatay", LastName = "KURTAY", Departmant = "POLICE"};
            personManager.Add(student1);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }

        class Customer : IPerson
        {
            public int Id { get ; set ; }
            public string FirstName { get ; set ; }
            public string LastName { get ; set ; }
            public string Adress { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get ; set ; }
            public string FirstName { get ; set ; }
            public string LastName { get; set ; }
            public string Departmant { get; set; }

        }
        class Worker : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }

            class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
                
            }
        }
        
    }

}
