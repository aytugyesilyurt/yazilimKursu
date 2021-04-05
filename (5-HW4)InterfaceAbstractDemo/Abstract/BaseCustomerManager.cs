using _5_HW4_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_HW4_InterfaceAbstractDemo.Abstract
{
    // iki şirkette save işlemi yaptığı için ikisine de save kodları yazmamamız gerekiyor. Bunun için save yapan ICustomerService interfacesinin imzasını taşıyan bir abstract class oluşturarak ortak save komutunu buna yazarak direkt bu class'ı çağırabiliriz.
    public abstract class BaseCustomerManager : ICustomerService
    {
        // virtual yazarsak üzerine override edebiliriz
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " " + customer.LastName + " sisteme başarıyla kaydedildi");
        }
    }
}
