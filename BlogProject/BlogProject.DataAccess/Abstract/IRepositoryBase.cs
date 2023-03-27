using BlogProject.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.Abstract
{
    public interface IRepositoryBase<T> : IRepository<T> where T : BaseEntity, new()
    {
        bool Add(T entity);
        bool Remove(T entity);
        bool Remove(int id);
        bool Update(T entity);
        T GetById(int id);
        T GetFirst(Expression<Func<T, bool>> filter = null);
        IList<T> GetAll(Expression<Func<T, bool>> filter = null);
        int Save();
    }
}
