using System;

namespace ReferenceTypes_4_HW1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı 1 : " + sayi1);         // sayi1 değeri 20 olur. sadece sayi2 nin o anki değerini alır

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("Sayılar1[0] : " + sayilar1[0]);      // sayilar1[0] ın sonucu 1000 dir. saayilar 1 in değerini sayilar2 nin dizisine eşitleriz. elemanları olur

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Aytuğ";
            person2 = person1;
            person1.FirstName = "Çağatay";

            Console.WriteLine("person2.FirtName : " + person2.FirstName); // arraylerde olduğu gibi classlarda da adres eşitlemesi yapılır referans tip 


            Customer customer1 = new Customer();
            Employee employee1 = new Employee();

            Person person3 = customer1;
            customer1.FirstName = "Can";
            Console.WriteLine("customer1.FirstName : "+customer1.FirstName);  // customer bir person olduğu için customera person ataması yapılabilir.




        }
    }

    class Person        //BASE CLASS
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Customer : Person   // inheritance
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
}
