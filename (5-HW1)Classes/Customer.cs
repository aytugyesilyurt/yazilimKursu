using System;
using System.Collections.Generic;
using System.Text;

namespace _5_HW1_Classes
{
    class Customer
    {
        //field
        //public string FirstName;

        //property
        public int Id { get; set; }
        //private string _firstName; // genellikle bu kullanım yoktur ama istenirse bu şekilde de kullanılabilir
        //public string FirstName { 
        //    get { return "Mrs." + _firstName; }
        //    set { _firstName = value; } 
        //}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }


    }
}
