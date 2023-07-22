
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface IShopService
    {
        Task<IEnumerable<AllProductsViewModel>> AllProductsAsync();
        Task<ProductFormModel> GetAddProductAsync();
        Task AddProductAsync(ProductFormModel model);
    }
}
