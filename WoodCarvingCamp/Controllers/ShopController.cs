using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Web.Controllers
{
    [Authorize]
    public class ShopController : Controller
    {
        private readonly IShopService shopService;

        public ShopController(IShopService shopService)
        {
            this.shopService = shopService;
        }
        [AllowAnonymous]
        public async Task<IActionResult> All()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            IEnumerable<AllProductsViewModel> allProducts =
                await this.shopService.AllProductsAsync();

            return View(allProducts);
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
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
    }
}
