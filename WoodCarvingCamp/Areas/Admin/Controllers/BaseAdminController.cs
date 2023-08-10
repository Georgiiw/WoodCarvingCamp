using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static WoodCarvingCamp.Common.AdminUserValidations.AdminValidations;
namespace WoodCarvingCamp.Web.Areas.Admin.Controllers
{
	[Area(AdminAreaName)]
	[Authorize(Roles = AdminRoleName)]
	public class BaseAdminController : Controller
	{
		
	}
}
