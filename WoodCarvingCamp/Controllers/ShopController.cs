﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Services.Data.Models.Shop;
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
