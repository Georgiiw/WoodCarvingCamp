using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WoodCarvingCamp.Data.Models;


namespace WoodCarvingCamp.Data.Configurations
{
    public class GalleryEntityConfiguration : IEntityTypeConfiguration<GalleryPhoto>
    {
        public void Configure(EntityTypeBuilder<GalleryPhoto> builder)
        {
            builder.HasData(this.GenerateProducts());
        }

        private GalleryPhoto[] GenerateProducts()
        {
            ICollection<GalleryPhoto> photos = new HashSet<GalleryPhoto>();

            GalleryPhoto photo;

            photo = new GalleryPhoto()
            {
                Id = 1,
                Description = "Beautiful flower carved in wood.",
                ImageUrl = "/images/GalleryImages/flower carved in wood.jpeg",
                CreatedOn = DateTime.Now,
            };
            photos.Add(photo);

            photo = new GalleryPhoto()
            {
                Id = 2,
                Description = "Jesus Face - Just Extraordinary.",
                ImageUrl = "/images/GalleryImages/Jesus Face.jpeg",
                CreatedOn = DateTime.Now,
            };
            photos.Add(photo);

            photo = new GalleryPhoto()
            {
                Id = 3,
                Description = "Owl - Amazing work.",
                ImageUrl = "/images/GalleryImages/Owl.jpg",
                CreatedOn = DateTime.Now,
            };
            photos.Add(photo);

            return photos.ToArray();

        }
    }
}
