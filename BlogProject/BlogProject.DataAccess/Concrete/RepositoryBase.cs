using BlogProject.DataAccess.Abstract;
using BlogProject.Entities.Context;
using BlogProject.Entities.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace BlogProject.DataAccess.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : BaseEntity, new()
    {
        private readonly SqlDbContext _db;
        public RepositoryBase(SqlDbContext db)
        {
            _db = db;
        }
        public DbSet<T> Table => _db.Set<T>();

        public bool Add(T entity)
        {
            EntityEntry<T> entityEntry = Table.Add(entity);
            return entityEntry.State == EntityState.Added;
        }

        public bool Remove(T entity)
        {
            EntityEntry<T> entityEntry = Table.Remove(entity);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool Remove(int id)
        {
            T model = Table.Find(id);
            return Remove(model);
        }
        public bool Update(T entity)
        {
            EntityEntry entityEntry = Table.Update(entity);
            return entityEntry.State == EntityState.Modified;
        }

        public IList<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            if (filter == null)
                return Table.ToList();
            else
                return Table.Where(filter).ToList();
        }

        public T GetById(int id)
            => Table.Find(id);


        public T GetFirst(Expression<Func<T, bool>> filter = null)
        => Table.Where(filter).FirstOrDefault();


        public int Save()
        => _db.SaveChanges();

    }
}
