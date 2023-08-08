using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WoodCarvingCamp.Data.Models;

namespace WoodCarvingCamp.Data.Configurations
{
    public class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(this.GenerateProducts());
        }

        private Product[] GenerateProducts()
        {
            ICollection<Product> products = new HashSet<Product>();

            Product product;

            product = new Product()
            {
                Id = 1,
                Name = "5 Piece - Set Starter - Carving Chisels",
                Description = "Woodworking chisels range from small hand tools for tiny details," +
                " to large chisels used to remove big sections of wood, in 'roughing out' the shape of a pattern or design.",
                Price = 49.99m,
                ImageUrl = "/Images/ShopImages/Chisel one.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 1
            };
            products.Add(product);

            product = new Product()
            {
                Id = 2,
                Name = "Hook Carving Knife",
                Description = "Hook Carving Knife good for carcing spoons or making special details on your special projects",
                Price = 15.99m,
                ImageUrl = "/Images/ShopImages/Knife one.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 3,
                Name = "Hook Carving Knifes Set",
                Description = "Set of four knife made to help you carve your perfect project!",
                Price = 45.99m,
                ImageUrl = "/Images/ShopImages/Knife two.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 4,
                Name = "Carving Knife",
                Description = "The one knife you need the most - the basic carving knife to start your journey!",
                Price = 9.99m,
                ImageUrl = "/Images/ShopImages/Knife three.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 2
            };
            products.Add(product);

            product = new Product()
            {
                Id = 5,
                Name = "Small Carving Chisel For Wood Carving",
                Description = "Set of four knife made to help you carve your perfect project!",
                Price = 9.99m,
                ImageUrl = "/Images/ShopImages/Chisel two.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 1
            };
            products.Add(product);

            product = new Product()
            {
                Id = 6,
                Name = "Level 6a Resistant Cut Gloves",
                Description = "Really good gloves to avoid accidentally cuts and injuries!",
                Price = 20.00m,
                ImageUrl = "/Images/ShopImages/Gloves one.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 3
            };
            products.Add(product);

            product = new Product()
            {
                Id = 7,
                Name = "Wood Carving Gloves",
                Description = "Really good gloves to avoid accidentally cuts and injuries!",
                Price = 15.49m,
                ImageUrl = "/Images/ShopImages/Gloves two.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 3
            };
            products.Add(product);

            product = new Product()
            {
                Id = 8,
                Name = "Tools Storage",
                Description = "Tools storage to store your knifes, chisels and other accessories!",
                Price = 30.49m,
                ImageUrl = "/Images/ShopImages/Tools Storage.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 5
            };
            products.Add(product);

            product = new Product()
            {
                Id = 9,
                Name = "Sharpening stone",
                Description = "Kepp your knifes sharp to make shure you have the perfect expirince while doing your projects!",
                Price = 30.49m,
                ImageUrl = "/Images/ShopImages/Sharpening stone.jpg",
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CategoryId = 4
            };
            products.Add(product);

            return products.ToArray();
        }
    }
}
