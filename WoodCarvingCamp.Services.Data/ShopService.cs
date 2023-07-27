using Microsoft.EntityFrameworkCore;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Services.Data.Models.Shop;
using WoodCarvingCamp.Web.ViewModels.Category;
using WoodCarvingCamp.Web.ViewModels.Shop;
using WoodCarvingCamp.Web.ViewModels.Shop.Enums;

namespace WoodCarvingCamp.Services.Data
{
    public class ShopService : IShopService
    {
        private readonly WoodCarvingCampDbContext dbContext;

        public ShopService(WoodCarvingCampDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddProductAsync(ProductFormModel model)
        {
            Product newProduct = new Product
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,               
                Price = model.Price,
                CreatedOn = model.CreatedOn,
                UpdatedOn = model.UpdatedOn,
                CategoryId = model.CategoryId
            };
            newProduct.CreatedOn = DateTime.UtcNow;
            newProduct.UpdatedOn = DateTime.UtcNow;
            
            await this.dbContext.AddAsync(newProduct);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<AllProductsFilteredServiceModel> AllAsync(AllProductsQuerryModel querryModel)
        {
            IQueryable<Product> productsQuerry = this.dbContext.Products.AsQueryable();

            if (!string.IsNullOrWhiteSpace(querryModel.Category))
            {
                productsQuerry = productsQuerry
                    .Where(p => p.Category.Name == querryModel.Category);
            }

            productsQuerry = querryModel.ProductSorting switch
            {
                ProductSorting.Newest => productsQuerry
                .OrderByDescending(p => p.CreatedOn), 
                ProductSorting.Oldest => productsQuerry
                .OrderBy(p => p.CreatedOn),
                ProductSorting.PriceAscending => productsQuerry
                .OrderBy(p => p.Price),
                ProductSorting.PriceDescending => productsQuerry
                .OrderByDescending(p => p.Price),
                _ => productsQuerry.OrderBy(p => p.Id )
            };

            IEnumerable<AllProductsViewModel> allProducts = await productsQuerry
                .Select(p => new AllProductsViewModel
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    ImageUrl = p.ImageUrl,
                    
                }).ToArrayAsync();

            int totalProducts = productsQuerry.Count();

            return new AllProductsFilteredServiceModel()
            {
                TotalProductsCount = totalProducts,
                Products = allProducts
            };
        }

        public async Task<IEnumerable<AllProductsViewModel>> AllProductsAsync()
        {
            IEnumerable<AllProductsViewModel> allProducts = await this
                .dbContext
                .Products
                .Select(p => new AllProductsViewModel
                {
                    Id = p.Id.ToString(),
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    CreatedOn = p.CreatedOn,                   
                }).ToListAsync();
            return allProducts;
        }

        public async Task<ProductFormModel> GetAddProductAsync()
        {
            var categories = await this.dbContext.Categories
                .Select(c => new CategoryViewModel()
                {
                    Id = c.Id,
                    Name = c.Name
                }).ToListAsync();

            var model = new ProductFormModel
            {
                Categories = categories
            };

            return model;
        }
    }
}
