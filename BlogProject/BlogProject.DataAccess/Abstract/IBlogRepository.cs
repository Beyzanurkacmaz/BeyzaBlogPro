using BlogProject.Entities.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DataAccess.Abstract
{
    public interface IBlogRepository:IRepositoryBase<Blogs>
    {
    }
}
