using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Business
{
     class HourlySalary : Contract
    {
        public override int AnnualSalary(int HourlySalary)
        {
            return 120 * HourlySalary * 12;
        }
    }
}
