using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Core
{
    public class DtoEmployess
    {
        private int _id;
        private string _name;
        private string _contractTypeName;
        private string _roleName;
        private string _roleDescription;
        private decimal _salary;
        private decimal _annualSalary;
      
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string ContractTypeName { get => _contractTypeName; set => _contractTypeName = value; }
        public string RoleName { get => _roleName; set => _roleName = value; }
        public string RoleDescription { get => _roleDescription; set => _roleDescription = value; }
        public decimal Salary { get => _salary; set => _salary = value; }
        public decimal AnnualSalary { get => _annualSalary; set => _annualSalary = value; }
    }

}
