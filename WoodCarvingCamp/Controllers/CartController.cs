using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Security.Claims;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.Cart;
using WoodCarvingCamp.Web.ViewModels.Order;
using static WoodCarvingCamp.Common.NotificationMessagesConstants;
namespace WoodCarvingCamp.Web.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartService cartService;
        private readonly IOrderService orderService;

        public CartController(ICartService cartService, IOrderService orderService)
        {
            this.cartService = cartService;
            this.orderService = orderService;
        }

        public async Task<IActionResult> Index()
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var shoppingCart = await this.cartService.GetShoppingCart(userId);
            return this.View(shoppingCart);
        }
        [HttpGet]
        public async Task<IActionResult> Add([FromRoute] int id)
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            try
            {
                await this.cartService.AddProductToCart(id, userId);

            }
            catch (Exception)
            {
                TempData[ErrorMessage] = "There was an error while adding your product to cart!";
                return RedirectToAction("All", "Shop");
            }

            TempData[SuccessMessage] = "Successfully added to cart";
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
        [HttpGet]
        public async Task<IActionResult> Summary()
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var shoppingCart = await this.cartService.GetShoppingCart(userId);
            if (!shoppingCart.CartItems.Any())
            {
                return this.RedirectToAction("Index", "Cart");
            }
            return this.View(shoppingCart);
        }

        [HttpPost]
        public async Task<IActionResult> Summary(string stripeToken)
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            var shoppingCart = await this.cartService.GetShoppingCart(userId);
           
            var order = new OrderViewModel()
            {
                Products = shoppingCart.CartItems,
                TotalPrice = shoppingCart.TotalPrice,
                CreatedOn = DateTime.Now,
                OrderStatus = "pending",
                PaymentStatus = "pending",
            };
            try
            {
             await this.orderService.Order(stripeToken, userId, order);

            }
            catch (Exception)
            {
                RedirectToAction("Index", "Cart");
            }

            await this.cartService.RemoveAllItems(userId);
            return this.RedirectToAction("OrderConfirmation", "Cart", new { id = order.Id });
        }

        
        public IActionResult OrderConfirmation(int id)
        {
            return this.View(id);
        }
    }
}
