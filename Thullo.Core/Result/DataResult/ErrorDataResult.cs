using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Result.DataResult
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(List<string> messages) : base(false, messages) { }
    }
}
