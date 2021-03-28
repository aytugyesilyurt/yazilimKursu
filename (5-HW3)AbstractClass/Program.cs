using System;

namespace _5_HW3_AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    abstract class MevzuatBase
    {
        public abstract void Degerlendir();

        public void Kaydet()
        {
            Console.WriteLine("Sisteme kaydedildi");
        }
    }

    class AMevzuat:MevzuatBase
    {
        // override komutu -- abstractta bir komut belirtilmiş ama herkes kendine göre bunu kullansın ( interface mantığı )
        public override void Degerlendir()
        {
            Console.WriteLine("A mevzuatına göre hesap yapıldı");
        }
    }

    class BMevzuat : MevzuatBase
    {
        public override void Degerlendir()
        {
            Console.WriteLine("B mevzuatına göre hesap yapıldı");
        }
    }

    // classlar birbiri ile ilgili operasyonları tutar
    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Added");
        }

        public void Update()
        {
            Console.WriteLine("Updated");
        }

    }

    // classlar property de tutar
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
