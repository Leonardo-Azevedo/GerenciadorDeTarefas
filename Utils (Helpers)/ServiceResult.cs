using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TasksWithBD.Utils__Helpers_
{
    public class ServiceResult
    {
        public bool Success { get; set; }
        public string Message { get; set; }

        public ServiceResult(bool success, string message = "")
        {
            Success = success;
            Message = message;
        }
    }
}
