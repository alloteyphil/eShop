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
    public class CartController : Controller
    {
        private readonly IHttpContextAccessor HttpContextAccessor;

        public CartController(IHttpContextAccessor httpContextAccessor)
        {
            this.HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            var cookieCart = HttpContextAccessor.HttpContext.Request.Cookies["Cart"];

            CartViewModel cartViewModel = new CartViewModel()
            {
                CartItems = cookieCart!=null ? JsonConvert.DeserializeObject<List<Cart>>(cookieCart) : new List<Cart>()
            };

            return View(cartViewModel);
        }

        public IActionResult Clear()
        {
            CookieOptions cookieOptions = new CookieOptions();
            Response.Cookies.Append("Cart", JsonConvert.SerializeObject(new List<Cart>()), cookieOptions);
            return RedirectToAction("Index");
        }
    }
}
