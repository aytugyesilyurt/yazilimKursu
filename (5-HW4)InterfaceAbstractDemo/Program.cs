using System;
using _5_HW4_InterfaceAbstractDemo.Abstract;
using _5_HW4_InterfaceAbstractDemo.Adapters;
using _5_HW4_InterfaceAbstractDemo.Concrete;
using _5_HW4_InterfaceAbstractDemo.Entities;

namespace _5_HW4_InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // BaseCustomerManageri interfaceye atadığımız için bu obje oluşturulurken sadece interfacenin kayıtlı olduğu 
            BaseCustomerManager baseCustomerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ad";
            customer1.LastName = "Soyad";
            customer1.DateOfBirth = new DateTime(1970, 1, 1);
            customer1.NationalityId = "123456789";

            baseCustomerManager.Save(customer1);

            Console.ReadLine();
        }
    }
}
