using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
    abstract class Creator 
    {
        public abstract IContract FactoryMethod();
        public decimal getContract(decimal Salary)
        {
            var product = FactoryMethod();
            var result = product.AnnualSalary(Salary);
            return result;
        }
    }
}
