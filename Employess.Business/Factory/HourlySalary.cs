using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
       class HourlySalary : IContract
    {
        public decimal AnnualSalary(decimal Salary)
        {
            return 120 * Salary * 12;;
        }
    }
}
