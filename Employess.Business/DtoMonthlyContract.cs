using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
    public class DtoMonthlyContract
    {
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal Salary { get; set; }
        public decimal AnnualSalary { get; set; }
    }
   
}
