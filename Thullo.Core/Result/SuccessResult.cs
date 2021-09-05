using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Result
{
    public class SuccessResult : Result
    {
        public SuccessResult(List<string> messages) : base(true, messages)
        {

        }
        public SuccessResult() : base(true, new()) { }
    }
}
