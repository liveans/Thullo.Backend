using System.Collections.Generic;

namespace Thullo.Core.Result
{
    public class ErrorResult : Result
    {
        public ErrorResult(List<string> messages) : base(false, messages)
        {

        }
        public ErrorResult() : base(false, new()) { }
    }
}
