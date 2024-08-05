using CleanBlog.UI.Data;
using Microsoft.AspNetCore.Mvc;

namespace CleanBlog.UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail(int id)
        {
            var res = _context.Articles.FirstOrDefault(x => x.Id == id);
            return View(res);
        }
    }
}
