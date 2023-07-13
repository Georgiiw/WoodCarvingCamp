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
            try
            {
                CarvingCourseFormModel courseModel = new CarvingCourseFormModel();

                return View(courseModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Course");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarvingCourseFormModel model)
        {
            model.AddedOn = DateTime.UtcNow;

            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.carvingCourseService.AddCourseAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "An error occurred.");
            }
            

            return this.RedirectToAction("All", "Course");
        }
        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            try
            {
                CarvingCourseFormModel courseModel =
                    await this.carvingCourseService.GetForEditByIdAsync(id);

                return View(courseModel);

            }
            catch (Exception)
            {

                return this.RedirectToAction("All", "Course");
            }
        }
        [HttpPost]

        public async Task<IActionResult> Edit(CarvingCourseFormModel courseModel, string id)
        {
            if (!ModelState.IsValid)
            {
                return this.View(courseModel);
            }

            try
            {
                await this.carvingCourseService.EditByIdAsync(id, courseModel);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "An error occurred.");

                return View(courseModel);
            }

            return RedirectToAction("All", "Course");
        }


    }
}
