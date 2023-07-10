using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.CarvingCourse;

namespace WoodCarvingCamp.Web.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICarvingCourseService carvingCourseService;

        public CourseController(ICarvingCourseService carvingCourseService)
        {
            this.carvingCourseService = carvingCourseService;
        }
        [AllowAnonymous]
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

        [HttpGet]
        public IActionResult Add()
        {
            CarvingCourseFormModel courseModel = new CarvingCourseFormModel();

            return View(courseModel);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarvingCourseFormModel model)
        {
            model.AddedOn = DateTime.UtcNow;

            if (!ModelState.IsValid)
            {
                return this.View(model);
            }
            await this.carvingCourseService.AddCourseAsync(model);

            return this.RedirectToAction("All", "Course");
        }
    }
}
