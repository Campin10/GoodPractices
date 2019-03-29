using System;
using System.Collections.Generic;
using System.Text;

namespace Employess.Data
{
    public class ResponseServices
    {
        private bool _state;
        private string _message;
        private List<Employe> _data;
        private string _type;

        public bool State { get => _state; set => _state = value; }
        public string Message { get => _message; set => _message = value; }
        public List<Employe> Data { get => _data; set => _data = value; }
        public string Type { get => _type; set => _type = value; }
    }
}
