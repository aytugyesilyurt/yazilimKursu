using System;
using System.Collections.Generic;
using System.Text;
using _5_HW4_InterfaceAbstractDemo.Abstract;
using _5_HW4_InterfaceAbstractDemo.Entities;

namespace _5_HW4_InterfaceAbstractDemo.Concrete
{
    // Mernis doğrulamasını starbucks nesnesinden ayrı olarak yaparsak ilerde tekrar başka şirketlerde de kullanılabilir.
    public class CustomerCheckManager:ICustomerCheckService
    {
       public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
