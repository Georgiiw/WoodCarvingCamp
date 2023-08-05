using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.Infrastructure.Extensions;
using WoodCarvingCamp.Web.ViewModels.GalleryPhoto;

namespace WoodCarvingCamp.Web.Controllers
{
    [Authorize]
    public class GalleryController : Controller
    {
        private readonly IGalleryService galleryService;

        public GalleryController(IGalleryService galleryService)
        {
            this.galleryService = galleryService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
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
                GalleryPhotoFormModel courseModel = new GalleryPhotoFormModel();

                return View(courseModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("Index", "Gallery");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(GalleryPhotoFormModel model)
        {
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
                await this.galleryService.AddPhotoAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "An error occurred.");
            }
            return RedirectToAction("Index", "Gallery");
        }
    }
}
