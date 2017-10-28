using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SperroFunctions.Models
{
    public class Customer
    {
        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string FirstName { get; set; }

        public Address Address { get; set; }

        public string Email { get; set; }

        public string SecondaryEmail { get; set; }

        public string Phone { get; set; }
    }
}
