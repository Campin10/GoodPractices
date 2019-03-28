using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
     class MonthlySalary : Contract
    {
        public override int AnnualSalary(int Salary)
        {
            return Salary * 12;
        }
    }
}
