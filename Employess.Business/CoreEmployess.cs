﻿using System;
using Employess.Data;
using System.Linq;
using System.Collections.Generic;

namespace Employess.Core
{
    public class CoreEmployess
    {
        ServiceRest _serviceRest;
       
        public List<DtoMonthlyContract> GetEmployess() {
            List<DtoMonthlyContract> result = new List<DtoMonthlyContract>();
            _serviceRest = new ServiceRest();
            List<Employe> data = (_serviceRest.CallService("", "http://masglobaltestapi.azurewebsites.net/api/Employees")).Result.Data;
            result = data.Select(empl => new DtoMonthlyContract
            {
                Name = empl.name,
                ContractTypeName = empl.contractTypeName,
                Salary = empl.contractTypeName == "MonthlySalaryEmployee" ? empl.monthlySalary : empl.hourlySalary,
                AnnualSalary = Creator.CreateContract(empl.contractTypeName).AnnualSalary(empl.contractTypeName == "MonthlySalaryEmployee" ? empl.monthlySalary : empl.hourlySalary),
                RoleName = empl.roleName,
                RoleDescription = empl.roleDescription
            }).ToList();
            return result;
        }


    }
}
