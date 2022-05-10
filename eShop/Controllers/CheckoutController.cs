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
    public class CheckoutController : Controller
    {
        private EShopDbContext DbContext;
        private readonly IHttpContextAccessor HttpContextAccessor;

        public CheckoutController(IHttpContextAccessor httpContextAccessor)
        {
            DbContext = new EShopDbContext();
            this.HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            var cookieUser = HttpContextAccessor.HttpContext.Request.Cookies["User"];
            var user = cookieUser != null ? JsonConvert.DeserializeObject<User>(cookieUser) : null;

            if (user == null)
            {
                return RedirectToAction("Index","Login");
            }
            else
            {
                return View();
            }
        }

        public async Task<IActionResult> PlaceOrder(CheckoutViewModel checkoutViewModel)
        {
            var cookieCart = HttpContextAccessor.HttpContext.Request.Cookies["Cart"];
            var cookieUser = HttpContextAccessor.HttpContext.Request.Cookies["User"];
            var cartItems = JsonConvert.DeserializeObject<List<Cart>>(cookieCart);
            var user = JsonConvert.DeserializeObject<User>(cookieUser);

            if (cartItems.Count > 0)
            {
                Order order = new Order()
                {
                    DeliveryAddress = checkoutViewModel.DeliveryAddress,
                    UserId = user.Email,
                    DateTime = DateTime.Now
                };

                foreach (var cartItem in cartItems)
                {
                    OrderItem orderItem = new OrderItem()
                    {
                        ProductId = cartItem.ProductId,
                        Price = cartItem.Price,
                        Quantity = cartItem.Quantity,
                        TotalAmount = cartItem.Price * cartItem.Quantity,
                    };

                    order.OrderItems.Add(orderItem);
                }

                DbContext.Orders.Add(order);
                await DbContext.SaveChangesAsync();

                CookieOptions cookieOptions = new CookieOptions();
                Response.Cookies.Append("Cart", JsonConvert.SerializeObject(new List<Cart>()), cookieOptions);

                return RedirectToAction("Index", "ThankYou");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}
