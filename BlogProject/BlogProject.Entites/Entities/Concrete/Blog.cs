using BlogProject.Entities.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Entities.Entities.Concrete
{
    public class Blogs:BaseEntity
    {
        public int Id { get; set; }
        public string BTitle { get; set; }
        public string BCategory { get; set; }
        public string BDesc { get; set; }
        public string BUrl { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
