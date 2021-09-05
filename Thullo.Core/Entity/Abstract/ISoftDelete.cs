using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thullo.Core.Entity.Abstract
{
    public interface ISoftDelete
    {
        [Column("deleted_at", Order = 1000)]
        public DateTime DeletedAt { get; set; }
    }
}
