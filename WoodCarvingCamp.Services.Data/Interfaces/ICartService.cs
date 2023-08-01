

using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Web.ViewModels.Cart;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface ICartService
    {
        Task AddProductToCart(int productId, string userId);
        Task<ShoppingCartViewModel> GetShoppingCart(string userId);
    }
}
