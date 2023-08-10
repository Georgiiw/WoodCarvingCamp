using Microsoft.AspNetCore.Mvc;

namespace WoodCarvingCamp.Web.Areas.Admin.Controllers
{
	public class HomeController : BaseAdminController
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
