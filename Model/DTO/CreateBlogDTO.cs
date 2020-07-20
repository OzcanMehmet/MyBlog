using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using myblog.Model.Entity;

namespace myblog.Model.DTO
{
    public class CreateBlogDTO
    {
        [Required]
        public string Subject { get ; set; }
        
        [Required]
        public string Content { get ; set; } 

        ICollection<BlogTag> Tags { get; set; }            
    }

}