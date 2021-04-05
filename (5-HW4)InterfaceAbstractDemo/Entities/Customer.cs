using _5_HW4_InterfaceAbstractDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace _5_HW4_InterfaceAbstractDemo.Entities
{
    // customer properties
    // IEntity için = somut sınıflar çıplak kalmamalı (ileride nesnellik zaafiyeti olabilir )
    public class Customer : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
    }
}
