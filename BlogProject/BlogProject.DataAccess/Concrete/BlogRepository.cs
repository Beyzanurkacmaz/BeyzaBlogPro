using BlogProject.DataAccess.Abstract;
using BlogProject.Entities.Context;
using BlogProject.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.Concrete
{
    public class BlogRepository : RepositoryBase<Blogs>, IBlogRepository
    {
        public BlogRepository(SqlDbContext db) : base(db)
        {
        }
    }
}
