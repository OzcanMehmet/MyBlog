using System;
using System.ComponentModel.DataAnnotations;

namespace myblog.Model.Entity
{
    public class EntityBase
    {
        [Required]
        public DateTime CreateDate { get; set; } = DateTime.Now; 
        public DateTime UpdateDate { get; set; } = DateTime.Now;
    }
}