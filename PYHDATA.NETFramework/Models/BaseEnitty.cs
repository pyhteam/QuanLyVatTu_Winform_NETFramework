using System;
using System.ComponentModel.DataAnnotations;

namespace PYHDATA.NETFramework.Models
{
    public class BaseEnitty
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}
