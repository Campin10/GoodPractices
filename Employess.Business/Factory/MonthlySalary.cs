using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
        class MonthlySalary : IContract
    {
        public decimal AnnualSalary(decimal Salary)
        {
             return Salary * 12;
        }
    }
}
