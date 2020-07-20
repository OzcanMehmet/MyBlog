using System;
using System.ComponentModel.DataAnnotations;

namespace myblog.Model.Entity
{
    public class BlogTag :EntityBase
    {
        public int   Id { get ; set; }
        
        [Required]
        public Tag  Tag { get; set; }

        [Required]
        public Blog Blog { get; set; }
    }
}
