using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Business
{
     class MonthlySalary : Contract
    {
        public override int AnnualSalary(int MonthlySalary)
        {
            return MonthlySalary * 12;
        }
    }
}
