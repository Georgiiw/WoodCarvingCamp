using Microsoft.AspNetCore.Mvc;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.CarvingCourse;

namespace WoodCarvingCamp.Web.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICarvingCourseService carvingCourseService;

        public CourseController(ICarvingCourseService carvingCourseService)
        {
            this.carvingCourseService = carvingCourseService;
        }

        public async Task<IActionResult> All()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            IEnumerable<CarvingCourseAllViewModel> allCourses =
                await this.carvingCourseService.AllCoursesAsync();

            return View(allCourses);

        }
    }
}
