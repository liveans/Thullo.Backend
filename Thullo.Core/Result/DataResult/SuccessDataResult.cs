using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Result.DataResult
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, List<string> messages) : base(true, messages, data)
        {

        }

        public SuccessDataResult(T data) : base(true, new List<string>(), data)
        {

        }
    }
}
