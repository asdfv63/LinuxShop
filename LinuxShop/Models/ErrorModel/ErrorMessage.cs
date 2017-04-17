using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinuxShop.Models
{
    public class ErrorMessage
    {
        public ErrorMessage(string message = "",bool success = true)
        {
            Success = success;
            Message = message;
        }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}
