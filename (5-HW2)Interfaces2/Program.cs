using System;

namespace _5_HW2_Interfaces2
{
    class Program
    {
        // interfaceler new'lenemez
        static void Main(string[] args)
        {
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager employeeManager = new EmployeeManager();
            employeeManager.Add();

            Console.ReadLine();

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
        void Update();

    }

    // classlarda - inherits  ------------- interfacede - implements
    class CustomerManager : IPersonManager 
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri sisteme kaydedildi.");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri kaydı güncellendi.");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel sisteme kaydedildi.");
        }

        public void Update()
        {
            Console.WriteLine("Personel kaydı güncellendi.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }

}
