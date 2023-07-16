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
    }
}
