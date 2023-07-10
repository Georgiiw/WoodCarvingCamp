using Microsoft.EntityFrameworkCore;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.CarvingCourse;

namespace WoodCarvingCamp.Services.Data
{
    public class CarvingCourseService : ICarvingCourseService
    {
        private readonly WoodCarvingCampDbContext dbContext;

        public CarvingCourseService(WoodCarvingCampDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddCourseAsync(CarvingCourseFormModel model)
        {
            CarvingCourse newCourse = new CarvingCourse
            {
                Name = model.Name,
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                IsPaid = model.IsPaid,
                Price = model.Price,
                AddedOn = model.AddedOn
            };
            await this.dbContext.AddAsync(newCourse);
            await this.dbContext.SaveChangesAsync();
        
        }

        public async Task<IEnumerable<CarvingCourseAllViewModel>> AllCoursesAsync()
        {
            IEnumerable<CarvingCourseAllViewModel> allCourses = await dbContext
                .CarvingCourses
                .Select(c => new CarvingCourseAllViewModel
                {
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ImageUrl = c.ImageUrl,
                    IsPaid = c.IsPaid,
                    Price = c.Price,
                    AddedOn = c.AddedOn
                }).ToListAsync();

            return allCourses;
        }     
    }
}