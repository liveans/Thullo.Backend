using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Result
{
    public interface IResult
    {
        bool Success { get; set; }
        List<string> Messages { get; set; }
    }
}
