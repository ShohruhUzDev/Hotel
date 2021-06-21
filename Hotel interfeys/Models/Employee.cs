using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_interfeys.Models
{
   // [TableName("employee")]
   public  class Employee
    {
        public int Id { get; set; }
        public string  FirstName { get; set; }
        public string  LastName { get; set; }
        public string  Address { get; set; }
        public string  Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string  Email { get; set; }
    }
}
