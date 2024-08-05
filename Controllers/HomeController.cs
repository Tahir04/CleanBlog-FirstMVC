using CleanBlog.UI.Data;
using CleanBlog.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CleanBlog.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Article> articles = _context.Articles.ToList();
            return View(articles);
        }

        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult About()
        {
            List<About> abouts = _context.Abouts.ToList();
            return View(abouts);
        }
    }
}
