using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace myblog.Model.Entity
{
    public class Tag : EntityBase
    {
        public int   Id { get ; set; }
        
        [Required]
        public string Name { get ; set; }
    
        ICollection<BlogTag> Blog { get; set; }
    }    
}