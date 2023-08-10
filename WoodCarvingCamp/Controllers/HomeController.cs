using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WoodCarvingCamp.Web.ViewModels;
using static WoodCarvingCamp.Common.AdminUserValidations.AdminValidations;
namespace WoodCarvingCamp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
			if (this.User.IsInRole(AdminRoleName))
			{
                return this.RedirectToAction("Index", "Home", new {Area =AdminAreaName});
			}
            return View();
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