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
    public class LoginController : Controller
    {
        private EShopDbContext DbContext;

        public LoginController()
        {
            DbContext = new EShopDbContext();
        }

        public IActionResult Index()
        {
            LoginViewModel loginViewModel = new LoginViewModel();
            
            return View(loginViewModel);
        }

        public async Task<IActionResult> Authenticate(LoginViewModel loginViewModel)
        {
            var success = DbContext.Users.Any(u => u.Email == loginViewModel.Email && u.Password == loginViewModel.Password);

            if (success)
            {
                var user = DbContext.Users.Where(u => u.Email == loginViewModel.Email).FirstOrDefault();
                CookieOptions cookieOptions = new CookieOptions();
                Response.Cookies.Append("User", JsonConvert.SerializeObject(user), cookieOptions);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Email or password is incorrect!');</script>");
            }
        }

        public IActionResult Logout()
        {
            CookieOptions cookieOptions = new CookieOptions();
            Response.Cookies.Append("User", JsonConvert.SerializeObject(null), cookieOptions);

            return RedirectToAction("Index","Login");
        }
    }
}
