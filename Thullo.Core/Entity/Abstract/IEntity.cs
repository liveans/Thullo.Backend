using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thullo.Core.Entity.Abstract
{
    public interface IEntity<T>
    {
        [Column("id", Order = 0)]
        public T Id { get; set; }
    }
}
