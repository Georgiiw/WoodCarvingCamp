
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface IShopService
    {
        Task<IEnumerable<AllProductsViewModel>> AllProductsAsync();
    }
}
