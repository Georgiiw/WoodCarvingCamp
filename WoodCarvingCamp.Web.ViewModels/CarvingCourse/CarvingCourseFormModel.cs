using System.ComponentModel.DataAnnotations;

using static WoodCarvingCamp.Data.Common.EntityValidationConstants.CarvingCourseValidations;


namespace WoodCarvingCamp.Web.ViewModels.CarvingCourse
{
    public class CarvingCourseFormModel
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;
        [Required]
        [StringLength(ImageUrlMaxLength)]
        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; } = null!;
        [Required]
        public bool IsPaid { get; set; }      
        public decimal? Price { get; set; }
        [Required]
        public DateTime AddedOn { get; set; }
    }

}
