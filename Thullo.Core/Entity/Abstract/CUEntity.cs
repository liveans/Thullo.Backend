using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Thullo.Core.Entity.Abstract
{
    public abstract class CUEntity<T> : IEntity<T>
    {
        [Column("id", Order = 0)]
        public T Id { get; set; }
        [Column("created_at", Order = 998)]
        [Required]
        public DateTime CreatedAt { get; set; }
        [Column("updated_at", Order = 999)]
        public DateTime UpdatedAt { get; set; }
    }
}
