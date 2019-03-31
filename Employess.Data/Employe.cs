using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Data
{
    public class Employe
    {
        private int _id;
        private string _name;
        private string _contractTypeName;
        private string _roleName;
        private string _roleDescription;
        private decimal _hourlySalary;
        private decimal _monthlySalary;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string ContractTypeName { get => _contractTypeName; set => _contractTypeName = value; }
        public string RoleName { get => _roleName; set => _roleName = value; }
        public string RoleDescription { get => _roleDescription; set => _roleDescription = value; }
        public decimal HourlySalary { get => _hourlySalary; set => _hourlySalary = value; }
        public decimal MonthlySalary { get => _monthlySalary; set => _monthlySalary = value; }
    }
}
