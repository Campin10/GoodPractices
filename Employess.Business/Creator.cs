using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Business
{
    public class Creator
    {
        public const int Hourly_Salary = 1;
        public const int Monthly_Salary = 2;

        public static Contract CreateContract(int TypeContract)
        {
            switch(TypeContract)
            {
                case Hourly_Salary:
                    return new HourlySalary();
                case Monthly_Salary:
                    return new MonthlySalary();
                default: return null;
            }
        }
    }
}
