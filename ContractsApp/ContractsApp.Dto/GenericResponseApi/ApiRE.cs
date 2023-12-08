using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractsApp.Dto.GenericResponseApi
{
    public class ApiRE<T>
    {
        public T? Data { get; set; } = default;
        public string Message { get; set; } = "";
        public bool Sucess { get; set; } = false;
    }
}
