
using WoodCarvingCamp.Services.Data.Models.Shop;
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface IShopService
    {       
        Task<ProductFormModel> GetAddProductAsync();
        Task AddProductAsync(ProductFormModel model);
        Task<bool> ExistsByIdAsync(string productId);
        Task<ProductDetailsViewModel> GetDetailsByIdAsync(string productId);
        Task<AllProductsFilteredServiceModel> AllAsync(AllProductsQuerryModel querryModel);
        Task<ProductFormModel> GetForEditByIdAsync(string id);
        Task EditByIdAsync(string id, ProductFormModel courseModel);
        Task DeleteProduct(string id);
    }
}
