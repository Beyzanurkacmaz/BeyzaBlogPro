using BlogProject.BusinessLayer.Abstract;
using BlogProject.BusinessLayer.Concrete;
using BlogProject.Entities.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogManager _blogManager;

        public BlogController(IBlogManager blogManager)
        {
            _blogManager = blogManager;
        }

        public ActionResult Index()
        {
            var blogDetails = _blogManager.ListBlog();

            return View(blogDetails);
        }
        public ActionResult UploadBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UploadBlog(Blogs bg)
        {
            _blogManager.CreateBlog(bg);
            ViewBag.message = "Blog basari ile eklendi.";
            return View();
        }
        public ActionResult Food()
        {
            var foodArticle = _blogManager.ListBlog().Where(x => x.BCategory == "Food");
            return View(foodArticle);
        }

        public ActionResult Sports()
        {
            var sportsArticle = _blogManager.ListBlog().Where(x => x.BCategory == "Sports");
            return View(sportsArticle);
        }

        public ActionResult Movies()
        {
            var movieArticle = _blogManager.ListBlog().Where(x => x.BCategory == "Movies");
            return View(movieArticle);
        }

        public ActionResult Recepies()
        {

            return View();
        }
    }
}
