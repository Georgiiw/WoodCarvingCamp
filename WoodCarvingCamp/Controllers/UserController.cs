using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.User;
using static WoodCarvingCamp.Common.NotificationMessagesConstants;
namespace WoodCarvingCamp.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IUserService userService;

        public UserController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager,
            IUserService userService)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.userService = userService;
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
            TempData[SuccessMessage] = "Successfuly logged in!";
            return this.Redirect(model.ReturnUrl ?? "/Home/Index");
        }
        public async Task<IActionResult> Logout()
        {
            await this.signInManager.SignOutAsync();

            return this.RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> UserProfile()
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var model = await this.userService.GetUserProfile(userId);

            return this.View(model);
        }
    }
}
