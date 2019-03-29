using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
     class MonthlySalary : Contract
    {
        public override decimal AnnualSalary(decimal Salary)
        {
            return Salary * 12;
        }
    }
}
