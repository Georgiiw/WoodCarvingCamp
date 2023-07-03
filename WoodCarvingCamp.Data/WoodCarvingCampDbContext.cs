using HouseRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WoodCarvingCamp.Data.Models;

namespace WoodCarvingCamp.Data
{
    public class WoodCarvingCampDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public WoodCarvingCampDbContext(DbContextOptions<WoodCarvingCampDbContext> options)
            : base(options)
        {

        }
        public DbSet<CarvingCourse> CarvingCourses { get; set; } = null!;
        public DbSet<Comment> Comments { get; set; } = null!;
        public DbSet<Discount> Discounts { get; set; } = null!;
        public DbSet<GalleryPhoto> GalleryPhotos { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}