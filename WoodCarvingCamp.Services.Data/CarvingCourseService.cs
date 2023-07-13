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
            if (!newCourse.IsPaid)
            {
                newCourse.Price = null;
            }
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

        public async Task DeleteCourse(string id)
        {
            CarvingCourse courseToDelete = await this.dbContext
                .CarvingCourses
                .FirstAsync(c => c.Id.ToString() == id);

            this.dbContext.Remove(courseToDelete);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task EditByIdAsync(string id, CarvingCourseFormModel editedCourseModel)
        {
            CarvingCourse courseToEdit = await this.dbContext
                .CarvingCourses
                .FirstAsync(c => c.Id.ToString() == id);

            courseToEdit.Name = editedCourseModel.Name;
            courseToEdit.Description = editedCourseModel.Description;
            courseToEdit.ImageUrl = editedCourseModel.ImageUrl;
            courseToEdit.IsPaid = editedCourseModel.IsPaid;
            courseToEdit.Price = editedCourseModel.Price;

            if (!courseToEdit.IsPaid)
            {
                courseToEdit.Price = null;
            }

            await this.dbContext.SaveChangesAsync();

        }

        public async Task<CarvingCourseFormModel> GetForEditByIdAsync(string id)
        {
            CarvingCourse carvingCourse = await this.dbContext
                .CarvingCourses
                .FirstAsync(c => c.Id.ToString() == id);

            return new CarvingCourseFormModel()
            {
                Name = carvingCourse.Name,
                Description = carvingCourse.Description,
                ImageUrl = carvingCourse.ImageUrl,
                IsPaid = carvingCourse.IsPaid,
                Price = carvingCourse.Price
            };
        }
    }
}