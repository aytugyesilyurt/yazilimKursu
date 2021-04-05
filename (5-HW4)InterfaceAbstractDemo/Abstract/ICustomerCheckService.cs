using System;
using System.Collections.Generic;
using System.Text;
using _5_HW4_InterfaceAbstractDemo.Entities;

namespace _5_HW4_InterfaceAbstractDemo.Abstract
{
    // Mernis kontrol interfacesi ( ilerde farklı şirketlerde de kullanılabilmek için interface oluştururuz sadece starbucks altına yazılmaz.
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);

    }
}
