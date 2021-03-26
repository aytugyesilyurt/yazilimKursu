using System;

namespace _4_HW2_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // liste elemanı şeklinde yapılırsa default constructor çalışır, metot şeklinde yazılırsa constructor çalışır !!

            //Customer customer1 = new Customer { Id = 1, FirstName = "Aytuğ", LastName = "YEŞİLYURT", City = "İzmir" };

            Customer customer1 = new Customer(1, "Aytuğ", "YEŞİLYURT", "İzmir");

            //Customer customer2 = new Customer(2, "Berkay", "Aytaş", "Bolu");


            Console.WriteLine(customer1.FirstName);
            Customer customer2 = new Customer(2, "Berkay", "Aytaş", "Bolu");
            Console.WriteLine(customer2.City);
        }
    }

    class Customer
    {
        //default constructor
        public Customer()
        {
            Console.WriteLine("Sisteme veri girişi yapıldı!!");
        }
        // overload yapılabiliyor    //sağdakiler parametreleri
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

            Console.WriteLine("Yapıcı blok çalıştı");
        }
        public int Id { get; set; }          
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string City { get; set; }    

    }
}
