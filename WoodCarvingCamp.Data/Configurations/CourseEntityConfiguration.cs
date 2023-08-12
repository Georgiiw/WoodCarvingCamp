using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WoodCarvingCamp.Data.Models;


namespace WoodCarvingCamp.Data.Configurations
{
    public class CourseEntityConfiguration : IEntityTypeConfiguration<CarvingCourse>
    {
        public void Configure(EntityTypeBuilder<CarvingCourse> builder)
        {
            builder.HasData(this.GenerateProducts());
        }

        private CarvingCourse[] GenerateProducts()
        {
            ICollection<CarvingCourse> courses = new HashSet<CarvingCourse>();

            CarvingCourse course;

            course = new CarvingCourse()
            {
                Id = 1,
                AddedOn = DateTime.UtcNow,
                Description = "Learn how to carve curved snake",
                Name = "Snake carving course",
                ImageUrl = "/images/CourseImages/Snake carving course.png",
                IsPaid = true,
                Price = 19.99m
            };
            courses.Add(course);
            course = new CarvingCourse()
            {
                Id = 2,
                AddedOn = DateTime.UtcNow,
                Description = "Learn how to carve wooden mini statues",
                Name = "Mini statues carving course",
                ImageUrl = "/images/CourseImages/WoodenMiniStatues.png",
                IsPaid = false                
            };
            courses.Add(course);
            return courses.ToArray();
        }
    }
}

