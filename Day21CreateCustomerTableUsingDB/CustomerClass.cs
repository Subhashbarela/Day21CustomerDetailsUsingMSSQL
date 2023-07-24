using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21CreateCustomerTableUsingDB
{
    public class CustomerClass
    {
       
        public int CustomerId { get; set; }
        public string Customer_Name { get; set; }
        public long PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public int Salary { get; set; }
        public int Pincode { get; set; }
    }
}
