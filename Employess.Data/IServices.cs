using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Data
{
    public interface IServices
    {
        List<Employe> CallService(dynamic Json, string Config);
    }
}


