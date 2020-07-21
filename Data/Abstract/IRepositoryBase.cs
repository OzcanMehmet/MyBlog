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
        Task<IEnumerable<T>> GetAll(); 
        Task<IEnumerable<T>>  Select(Expression<Func<T, bool>> Filter = null); 
        Task<T> Insert(T Entity); 
        Task<T> Update(T Entity); 
        Task<T> Delete(int EntityId); 
        Task<T> Delete(T Entity); 
    }
}
