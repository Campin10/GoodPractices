using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
     class HourlySalary : Contract
    {
        public override int AnnualSalary(int Salary)
        {
            return 120 * Salary * 12;
        }
    }
}
