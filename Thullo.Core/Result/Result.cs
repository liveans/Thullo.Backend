using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Result
{
    public class Result : IResult
    {
        public bool Success { get; set; }
        public List<string> Messages { get; set; }
        public Result(bool success, List<string> messages)
        {
            Success = success;
            Messages = messages;
        }
    }
}
