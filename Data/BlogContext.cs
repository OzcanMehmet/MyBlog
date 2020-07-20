using Microsoft.EntityFrameworkCore;
using myblog.Model.Entity;

namespace myblog.Data
{
    public class BlogContex : DbContext
    {

        public BlogContex(DbContextOptions<BlogContex> ct):base(ct)
        {
            
        }
        public DbSet<Blog>     Blog { get; set; }
        public DbSet<Tag>      Tag { get; set; }
        public DbSet<BlogTag>  BlogTag { get; set; }
    }
}