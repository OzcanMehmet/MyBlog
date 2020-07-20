using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myblog.Model.Entity
{
    public class Blog : EntityBase
    {
        public int   Id { get ; set; }
        
        [Required]
        public string Subject { get ; set; }
        
        [Required]
        public string Content { get ; set; }

        ICollection<BlogTag> Tags { get; set; }
    }
}
