using Microsoft.EntityFrameworkCore;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Services.Data
{
    public class ShopService : IShopService
    {
        private readonly WoodCarvingCampDbContext dbContext;

        public ShopService(WoodCarvingCampDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<IEnumerable<AllProductsViewModel>> AllProductsAsync()
        {
            IEnumerable<AllProductsViewModel> allProducts = await this
                .dbContext
                .Products
                .Select(p => new AllProductsViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    CreatedOn = p.CreatedOn,                   
                }).ToListAsync();
            return allProducts;
        }
    }
}
