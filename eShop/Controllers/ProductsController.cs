using eShop.Models;
using eShop.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class ProductsController : Controller
    {
        private EShopDbContext DbContext;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public ProductsController(IHttpContextAccessor httpContextAccessor)
        {
            DbContext = new EShopDbContext();
            this.HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            ProductsViewModel productsViewModel = new ProductsViewModel()
            {
                Products = DbContext.Products.ToList()
            };

            return View(productsViewModel);
        }

        public IActionResult CategoryWise(string Id)
        {
            ProductsViewModel productsViewModel = new ProductsViewModel()
            {
                Products = DbContext.Products.Where(p => p.CategoryId == Convert.ToInt32(Id)).ToList(),
                Category = DbContext.Categories.Where(c => c.Id == Convert.ToInt32(Id)).FirstOrDefault()
            };

            return View(productsViewModel);
        }

        public IActionResult View(string Id)
        {
            var product = DbContext.Products.Where(p => p.Id == Convert.ToInt32(Id)).FirstOrDefault();
            product.Category = DbContext.Categories.Where(c => c.Id == product.CategoryId).FirstOrDefault();

            ProductsViewModel productsViewModel = new ProductsViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price.Value,
                Product = product
            };

            return View(productsViewModel);
        }

        public IActionResult AddToCart(ProductsViewModel productsViewModel)
        {
            List<Cart> cartItems = new List<Cart>();

            var cookieCart = HttpContextAccessor.HttpContext.Request.Cookies["Cart"];
            if (cookieCart != null)
            {
                cartItems = JsonConvert.DeserializeObject<List<Cart>>(cookieCart);
            }

            var product = DbContext.Products.Where(p => p.Id == productsViewModel.Id).FirstOrDefault();

            cartItems.Add(new Cart()
            {
                ProductId = productsViewModel.Id,
                ProductName = productsViewModel.Name,
                Quantity = productsViewModel.Quantity,
                Price = productsViewModel.Price
            });

            CookieOptions cookieOptions = new CookieOptions();
            Response.Cookies.Append("Cart", JsonConvert.SerializeObject(cartItems), cookieOptions);

            return RedirectToAction("Index", "Home");
        }
    }
}
