using System;

namespace _5_HW2_Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    //class PersonManager
    //{
    //    //implemented operation (tamamlanmış/içi doldurulmuş operasyon)
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }
    //}

    interface IPersonManager
    {
        //unimplemented operation (içi boş operasyon)
        void Add();
    }
    class CustomerManager : IPersonManager 
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri sisteme kaydedildi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel sisteme kaydedildi.");
        }
    }

}
