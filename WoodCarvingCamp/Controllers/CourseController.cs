using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.Infrastructure.Extensions;
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
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }
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
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
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
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }
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
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
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
        public async Task<IActionResult> Delete(string id)
        {
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }
            try
            {
                await this.carvingCourseService.DeleteCourse(id);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("All", "Course");
        }

    }
}
