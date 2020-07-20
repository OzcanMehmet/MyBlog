using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using myblog.Model.Entity;

namespace myblog.Data.Abstract
{
    public interface IRepositoryBase<T>  where T:EntityBase 
    {
        Task<T> FindById(int EntityId); 
        Task<IEnumerable<T>>  Select(Expression<Func<T, bool>> Filter = null); 
        Task Insert(T Entity); 
        Task Update(T Entity); 
        Task Delete(int EntityId); 
        Task Delete(T Entity); 
    }
}
