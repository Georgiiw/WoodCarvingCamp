﻿using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Web.ViewModels.User;

namespace WoodCarvingCamp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }
            ApplicationUser user = new ApplicationUser
            {
                FirstName = model.FirstName,
                LastName = model.LastName,             

            };          

            await this.userManager.SetEmailAsync(user, model.Email);
            await this.userManager.SetUserNameAsync(user, model.Email);

            IdentityResult result = await this.userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
                return this.View(model);
            }

            await this.signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Login(string? returnUrl = null)
        {
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            LoginFormModel model = new LoginFormModel()
            {
                ReturnUrl = returnUrl
            };

            return this.View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            var result = await this.signInManager
                .PasswordSignInAsync(model.Email, model.Password, false, false);

            if (!result.Succeeded)
            {
                return this.View(model);
            }

            return this.Redirect(model.ReturnUrl ?? "/Home/Index");
        }
    }
}
