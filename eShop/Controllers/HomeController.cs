using eShop.Models;
using eShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace eShop.Controllers
{
    public class HomeController : Controller
    {
        private EShopDbContext DbContext;
        public HomeController()
        {
            DbContext = new EShopDbContext();
        }

        public IActionResult Index()
        {
            var categories = DbContext.Categories.ToList();
            foreach(var category in categories)
            {
                category.Products = DbContext.Products.Where(p => p.CategoryId == category.Id).ToList();
            }

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Categories = DbContext.Categories.ToList()
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}