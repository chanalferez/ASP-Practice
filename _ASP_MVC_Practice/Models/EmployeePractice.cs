using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _ASP_MVC_Practice.Models
{
    public class EmployeePractice
    {
      
        public int PCId { get; set; }
        public long ServerIpAddress { get; set; }
        public int ServerPort { get; set; }
        public Nullable<bool> ServerSSL { get; set; }
        public long createDate { get; set; }
        public long modifiedDate { get; set; }
        public string test_Columns { get; set; }
      
    }
}