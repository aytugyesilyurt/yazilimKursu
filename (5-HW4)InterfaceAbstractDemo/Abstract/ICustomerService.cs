using System;
using System.Collections.Generic;
using System.Text;
using _5_HW4_InterfaceAbstractDemo.Entities;

namespace _5_HW4_InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        // iki firmada ortak olduğu için interface ile ortaklanmalı
        void Save(Customer customer);
    }
}
