using System.ComponentModel.DataAnnotations;


namespace WoodCarvingCamp.Web.ViewModels.CarvingCourse
{
    public class CarvingCourseAllViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        [Display(Name = "Image Path")]
        public string ImageUrl { get; set; } = null!;
        public bool IsPaid { get; set; }
        public decimal? Price { get; set; }
        public DateTime AddedOn { get; set; }

        
    }
}
