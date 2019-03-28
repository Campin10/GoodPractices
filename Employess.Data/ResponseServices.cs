using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Data
{
    public class ResponseServices
    {
        public bool State { get; set; }
        public string Message { get; set; }
        public List<Employe> Data { get; set; }
        public string Type { get; set; }
    }
}
