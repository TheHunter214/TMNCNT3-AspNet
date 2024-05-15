
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TMN_Lesson04.Models
{
    public class TMNCustomer
    {
        public int CustomerID {  get; set; }   
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string YearOfBirth{ get; set; }
    }
}