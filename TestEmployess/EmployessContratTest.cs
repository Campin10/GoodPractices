using System;
using Xunit;
using Employess.Core;

namespace TestEmployess
{
    public class EmployessContratTest
    {
        [Fact]
        public void TestMonthlySalary()
        {
            decimal Salary = Creator.CreateContract("MonthlySalaryEmployee").AnnualSalary(1000);
            Assert.Equal(12000, Salary);
        }

        [Fact]
        public void TestHourlySalary()
        {
            decimal Salary = Creator.CreateContract("HourlySalaryEmployee").AnnualSalary(1000);
            Assert.Equal(1440000, Salary);
        }
    }
}
