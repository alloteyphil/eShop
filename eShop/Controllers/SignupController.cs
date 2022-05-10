using eShop.Models;
using eShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class SignupController : Controller
    {
        private EShopDbContext DbContext;

        public SignupController()
        {
            DbContext = new EShopDbContext();
        }

        public IActionResult Index()
        {
            SignupViewModel signupViewModel = new SignupViewModel();

            return View(signupViewModel);
        }

        public async Task<IActionResult> CreateAccount(SignupViewModel signupViewModel)
        {
            if (!DbContext.Users.Any(u => u.Email == signupViewModel.Email))
            {
                User user = new User()
                {
                    Email = signupViewModel.Email,
                    FullName = signupViewModel.FullName,
                    Password = signupViewModel.Password,
                    AccountType = "Customer"
                };

                DbContext.Users.Add(user);
                await DbContext.SaveChangesAsync();

                return RedirectToAction("Index", "Login");
            }
            else
            {
                return Content("<script language='javascript' type='text/javascript'>alert('Email already exists!');</script>");
            }
        }
    }
}
