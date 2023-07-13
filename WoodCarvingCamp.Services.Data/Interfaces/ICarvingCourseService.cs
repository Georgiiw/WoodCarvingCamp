using WoodCarvingCamp.Web.ViewModels.CarvingCourse;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface ICarvingCourseService
    {
        Task<IEnumerable<CarvingCourseAllViewModel>> AllCoursesAsync();
        Task AddCourseAsync(CarvingCourseFormModel model);
        Task<CarvingCourseFormModel> GetForEditByIdAsync(string id);
        Task EditByIdAsync(string id, CarvingCourseFormModel courseModel);
    }
}
