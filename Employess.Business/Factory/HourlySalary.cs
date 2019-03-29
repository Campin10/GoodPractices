using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
     class HourlySalary : Contract
    {
        public override decimal AnnualSalary(decimal Salary)
        {
            return 120 * Salary * 12;
        }
    }
}
