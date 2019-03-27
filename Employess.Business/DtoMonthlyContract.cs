using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Business
{
    public class DtoMonthlyContract
    {
        public string name { get; set; }
        public string contractTypeName { get; set; }
        public string roleName { get; set; }
        public string roleDescription { get; set; }
        public int monthlySalary { get; set; }
        public int AnnualSalary { get { return Creator.CreateContract(Creator.Monthly_Salary).AnnualSalary(monthlySalary); } }
    }
   
}
