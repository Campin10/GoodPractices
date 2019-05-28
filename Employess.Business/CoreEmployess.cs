using System;
using Employess.Data;
using System.Linq;
using System.Collections.Generic;

namespace Employess.Core
{
    public class CoreEmployess
    {
        private IServices _serviceRest;
        public CoreEmployess(IServices serviceRest)
        {
            _serviceRest = serviceRest;
        }

        public List<DtoEmployess> GetEmployessData(string Url,int idEmploye) {
            List<Employe> data = _serviceRest.CallService(Url).Result.Data;
            List<DtoEmployess> result = (data.Select(empl => new DtoEmployess
            {
                Id = empl.Id,
                Name = empl.Name,
                ContractTypeName = empl.ContractTypeName,
                Salary = empl.ContractTypeName == "MonthlySalaryEmployee" ? empl.MonthlySalary : empl.HourlySalary,
                AnnualSalary = empl.ContractTypeName == "MonthlySalaryEmployee" ? new ConcreteMonthlySalary().getContract(empl.MonthlySalary) : new ConcreteHourlySalary().getContract((empl.HourlySalary)),
                RoleName = empl.RoleName,
                RoleDescription = empl.RoleDescription
            }).ToList());
            result = idEmploye > 0 ? result.Where(s => s.Id == idEmploye).ToList() : result;
            return result;
        }
    }
}
