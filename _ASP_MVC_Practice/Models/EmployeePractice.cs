using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _ASP_MVC_Practice.Models
{
    public class Employee
    {

        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public System.DateTime Date_Hired { get; set; }
        public Nullable<System.DateTime> Date_Resigned { get; set; }
        public int PCDetailed { get; set; }
        public bool Status { get; set; }
        public long createDate { get; set; }
        public Nullable<long> modifiedDate { get; set; }

    }
}