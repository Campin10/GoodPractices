using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Employess.Core;
using Newtonsoft.Json;

namespace employess.Controllers
{
    [Route("api/[controller]")]
    public class EmployessContractController : Controller
    {
        [HttpGet("[action]")]
        public IEnumerable<DtoEmployess> GetEmployess(){
            CoreEmployess core = new CoreEmployess();
            List<DtoEmployess> dataEmployess = core.GetEmployessData();
            return dataEmployess;
        }
    }
}