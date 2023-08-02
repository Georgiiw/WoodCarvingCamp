using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Services.Data.Models.Shop;
using WoodCarvingCamp.Web.Infrastructure.Extensions;
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Web.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private readonly IShopService shopService;
        private readonly ICategoryService categoryService;

        public ShopController(IShopService shopService, ICategoryService categoryService)
        {
            this.shopService = shopService;
            this.categoryService = categoryService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> All([FromQuery] AllProductsQuerryModel querryModel)
        {
            AllProductsFilteredServiceModel serviceModel = 
                await this.shopService.AllAsync(querryModel);

            querryModel.Products = serviceModel.Products;
            querryModel.TotalProducts = serviceModel.TotalProductsCount;
            querryModel.Categories = await this.categoryService.AllCategoryNamesAsync();

            return this.View(querryModel);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }
            try
            {
                ProductFormModel productModel = await this.shopService.GetAddProductAsync();              

                return View(productModel);
            }
            catch (Exception)
            {
                return this.RedirectToAction("All", "Shop");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductFormModel model)
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

                await this.shopService.AddProductAsync(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "An error occurred.");
            }

            return this.RedirectToAction("All", "Shop");
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(string id)
        {
            bool productExists = await shopService
                .ExistsByIdAsync(id);
            if (!productExists)
            {             
                return RedirectToAction("All", "Shop");
            }

            try
            {
                AllProductsViewModel viewModel = await shopService
                    .GetDetailsByIdAsync(id);               

                return View(viewModel);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
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
                ProductFormModel productModel =
                    await this.shopService.GetForEditByIdAsync(id);

                return View(productModel);

            }
            catch (Exception)
            {

                return this.RedirectToAction("All", "Shop");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductFormModel model, string id)
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
                await this.shopService.EditByIdAsync(id, model);
            }
            catch (Exception)
            {
                ModelState.AddModelError(string.Empty, "An error occurred.");

                return View(model);
            }

            return RedirectToAction("All", "Shop");
        }
        public async Task<IActionResult> Delete(string id)
        {
            if (User.IsAdmin() == false)
            {
                return Unauthorized();
            }
            try
            {
                await this.shopService.DeleteProduct(id);
            }
            catch (Exception)
            {

                throw;
            }
            return RedirectToAction("All", "Shop");
        }
    }
}
