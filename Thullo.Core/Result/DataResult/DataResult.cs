using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Result.DataResult
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public List<string> Messages { get; set; }
        public DataResult(bool success, List<string> messages, T data)
        {
            Success = success;
            Messages = messages;
            Data = data;
        }
        public DataResult(bool success, List<string> messages)
        {
            Success = success;
            Messages = messages;
        }
    }
}
