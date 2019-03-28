using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employess.Business;

namespace employess.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
     

        public int WeatherForecasts()
        {
            var data = Creator.CreateContract(Creator.Monthly_Salary).AnnualSalary(1000);
            return 1;
        }

        public class WeatherForecast
        {
            public string DateFormatted { get; set; }
            public int TemperatureC { get; set; }
            public string Summary { get; set; }

            public int TemperatureF
            {
                get
                {
                    return 32 + (int)(TemperatureC / 0.5556);
                }
            }
        }
    }
}
