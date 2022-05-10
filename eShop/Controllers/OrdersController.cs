using eShop.Models;
using eShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class OrdersController : Controller
    {
        private EShopDbContext DbContext;

        public OrdersController()
        {
            DbContext = new EShopDbContext();
        }
        
        public IActionResult Index()
        {
            var orders = DbContext.Orders.ToList();
            foreach(Order order in orders)
            {
                order.User = DbContext.Users.Where(u => u.Email == order.UserId).FirstOrDefault();
            }

            OrdersViewModel ordersViewModel = new OrdersViewModel()
            {
                Orders = orders
            };

            return View(ordersViewModel);
        }

        public IActionResult View(string id)
        {
            var order = DbContext.Orders.Where(o => o.Id == Convert.ToInt32(id)).FirstOrDefault();
            order.OrderItems = DbContext.OrderItems.Where(o => o.Id == Convert.ToInt32(id)).ToList();

            foreach(OrderItem orderItem in order.OrderItems)
            {
                orderItem.Product = DbContext.Products.Where(p => p.Id == orderItem.ProductId).FirstOrDefault();
            }

            OrdersViewModel ordersViewModel = new OrdersViewModel()
            {
                Order = order
            };

            return View(ordersViewModel);
        }
    }
}
