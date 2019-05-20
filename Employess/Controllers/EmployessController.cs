using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Employess.Core;
using Newtonsoft.Json;
using Microsoft.Extensions.Configuration;
using Employess.Data;

namespace employess.Controllers
{
    [Route("api/[controller]")]
    public class EmployessContractController : ControllerBase
    {
        private CoreEmployess coreEmployess;
        private readonly IConfiguration _configuration;
        public EmployessContractController(CoreEmployess _CoreEmployess, IConfiguration configuration)
        {
            coreEmployess = _CoreEmployess;
            _configuration = configuration;
        }

        [HttpGet("{id}")]
        public IEnumerable<DtoEmployess> GetEmployess(int idEmploye)
        {
            List<DtoEmployess> dataEmployess = coreEmployess.GetEmployessData(_configuration["ApiData"], idEmploye);
            return dataEmployess;
        }
    }
}