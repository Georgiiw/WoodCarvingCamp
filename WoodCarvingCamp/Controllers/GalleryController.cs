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
        public async Task<IActionResult> Index()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            IEnumerable<GalleryPhotoViewModel> photos =
                await this.galleryService.AllPhotos();

            return View(photos);
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

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            bool productExists = await galleryService
               .ExistsByIdAsync(id);
            if (!productExists)
            {
                return RedirectToAction("All", "Gallery");
            }

            try
            {
                GalleryPhotoViewModel viewModel = await galleryService
                    .GetDetailsByIdAsync(id);

                return View(viewModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }
            try
            {
                await this.galleryService.DeletePhoto(id);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("Index", "Gallery");
        }
    }
}
