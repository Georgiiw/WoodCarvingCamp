using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WoodCarvingCamp.Services.Data.Interfaces;

namespace WoodCarvingCamp.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartService cartService;

        public CartController(ICartService cartService)
        {
            this.cartService = cartService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var shoppingCart = await this.cartService.GetShoppingCart(userId);
            return this.View(shoppingCart);
        }

        public async Task<IActionResult> Add([FromRoute] int id)
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await this.cartService.AddProductToCart(id, userId);

            }
            catch (Exception)
            {              
                return RedirectToAction("All", "Shop");
            }

            return RedirectToAction("Index", "Cart");
        }

        public async Task<IActionResult> Remove(int id)
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            try
            {
                await this.cartService.RemoveItemFromCart(id, userId);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Cart");
        }

    }
}
