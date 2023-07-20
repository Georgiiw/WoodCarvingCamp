using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WoodCarvingCamp.Data.Models;

namespace WoodCarvingCamp.Data.Configurations
{
    public class CategoryEntityConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(this.GenerateCategories());
        }
        private Category[] GenerateCategories()
        {
            ICollection<Category> categories = new HashSet<Category>();

            Category category;

            category = new Category()
            {
                Id = 1,
                Name = "Carving Chisels"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 2,
                Name = "Carving Knives"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 3,
                Name = "Carving Gloves"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 4,
                Name = "Sharpening & Accessories"
            };
            categories.Add(category);

            category = new Category()
            {
                Id = 5,
                Name = "Carving Tools Storage"
            };
            categories.Add(category);

            return categories.ToArray();
        }
    }
}
