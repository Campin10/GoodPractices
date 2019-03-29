using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
    public static class Creator 
    {
        public static Contract CreateContract(string TypeContract)
        {
              switch (TypeContract)
            {
                case "HourlySalaryEmployee":
                    return new HourlySalary();
                case "MonthlySalaryEmployee":
                    return new MonthlySalary();
                default: return null;
            }
        }
    }
}
