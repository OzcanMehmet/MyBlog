using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using myblog.Data.Abstract;
using myblog.Model.Entity;

namespace myblog.Data.Concrete
{
    public class BlogRepository : IBlogRepository
    {   
        public BlogContex _context { get; set; }
        public BlogRepository(BlogContex context)
        {
            _context = context;
        }

        public async Task<Blog> FindById(int EntityId)
        {
            return await _context.Blog.FirstOrDefaultAsync(x=>x.Id==EntityId);
        }

        public async Task<IEnumerable<Blog>> Select(Expression<Func<Blog, bool>> Filter = null)
        {
            return await _context.Blog.Where(Filter).ToListAsync();
        }

        public async Task Insert(Blog Entity)
        {
            _context.Blog.Add(Entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Blog Entity)
        {
            _context.Blog.Update(Entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int EntityId)
        {
            await Delete(_context.Blog.FirstOrDefault(x=>x.Id==EntityId));
        }

        public async Task Delete(Blog Entity)
        {
            if(Entity!=null)
            {
                _context.Blog.Remove(Entity);
                await _context.SaveChangesAsync();
            }

        }
    }
}