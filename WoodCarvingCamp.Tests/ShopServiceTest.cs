
using NUnit.Framework;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Tests.Mocks;
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Tests
{
    [TestFixture]
    public class ShopServiceTest
    {
        private IShopService shopService;

        [Test]
        public async Task AddProductToDb()
        {
            using var data = DbMock.Instance;
            this.shopService = new ShopService(data);

            var product = new Product()
            {
                Id = 1,
                Name = "product1",
                Description = "pr desc pr desc pr desc pr desc pr desc pr desc ",
                ImageUrl = "imagepath",
                Price = 25.99m,
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow
            };
            var model = new ProductFormModel()
            {              
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                CategoryId = product.CategoryId,
                CreatedOn = product.CreatedOn
            };
            await data.Products.AddAsync(product);
            await data.SaveChangesAsync();

            await this.shopService.AddProductAsync(model);
            var dbProduct = data.Products.FirstOrDefault(p => p.Id == 1);

            Assert.That(dbProduct, Is.Not.Null);

        }
        [Test]
        public async Task EditProduct()
        {
            using var data = DbMock.Instance;
            this.shopService = new ShopService(data);

            var product = new Product()
            {
                Id = 1,
                Name = "product1",
                Description = "pr desc pr desc pr desc pr desc pr desc pr desc ",
                ImageUrl = "imagepath",
                Price = 25.99m,
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow
            };
            var model = new ProductFormModel()
            {
                Name = "NewName",
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                CategoryId = product.CategoryId,
                CreatedOn = product.CreatedOn
            };
            await data.Products.AddAsync(product);
            await data.SaveChangesAsync();

            await this.shopService.EditByIdAsync(product.Id.ToString(), model);
            var dbProduct = data.Products.FirstOrDefault(p => p.Id == 1);

            Assert.That(dbProduct.Name, Is.EqualTo("NewName"));
        }
        [Test]
        public async Task GetProductForEdit()
        {
            using var data = DbMock.Instance;
            this.shopService = new ShopService(data);

            var product = new Product()
            {
                Id = 1,
                Name = "product1",
                Description = "pr desc pr desc pr desc pr desc pr desc pr desc ",
                ImageUrl = "imagepath",
                Price = 25.99m,
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow
            };
            var model = new ProductFormModel()
            {
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                CategoryId = product.CategoryId,
                CreatedOn = product.CreatedOn
            };
            await data.Products.AddAsync(product);
            await data.SaveChangesAsync();

            await this.shopService.GetForEditByIdAsync(product.Id.ToString());
            var dbProduct = await this.shopService.GetForEditByIdAsync(product.Id.ToString());

            Assert.That(dbProduct, Is.Not.Null);
        }
        [Test]
        public async Task GetProductDetailsById()
        {
            using var data = DbMock.Instance;
            this.shopService = new ShopService(data);

            var category = new Category()
            {
                Id = 1,
                Name = "knife"
            };

            var product = new Product()
            {
                Id = 1,
                Name = "product1",
                Description = "pr desc pr desc pr desc pr desc pr desc pr desc ",
                ImageUrl = "imagepath",
                Price = 25.99m,
                Category = category,
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow
            };
            var model = new ProductDetailsViewModel()
            {
                Name = product.Name,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Price = product.Price,
                Category = category.Name,
                CreatedOn = product.CreatedOn
            };
            await data.Products.AddAsync(product);
            await data.SaveChangesAsync();
          
            var dbProduct = await this.shopService.GetDetailsByIdAsync(product.Id.ToString());

            Assert.That(dbProduct.Category, Is.EqualTo("knife"));
        }
        [Test]
        public async Task DeleteProduct()
        {
            using var data = DbMock.Instance;
            this.shopService = new ShopService(data);

            var product = new Product()
            {
                Id = 1,
                Name = "product1",
                Description = "pr desc pr desc pr desc pr desc pr desc pr desc ",
                ImageUrl = "imagepath",
                Price = 25.99m,
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow
            };       
            await data.Products.AddAsync(product);
            await data.SaveChangesAsync();

            await this.shopService.DeleteProduct("1");
            var dbProduct = data.Products.FirstOrDefault(p => p.Id == 1);

            Assert.That(dbProduct, Is.Null);

        }
    }
}
