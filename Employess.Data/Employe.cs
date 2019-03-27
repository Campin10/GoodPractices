using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Data
{
    public class Employe
    {
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public decimal hourlySalary { get; set; }
        public decimal monthlySalary { get; set; }
    }
}
