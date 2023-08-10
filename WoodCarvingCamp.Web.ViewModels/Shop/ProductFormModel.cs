using System.ComponentModel.DataAnnotations;

using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Web.ViewModels.Category;
using static WoodCarvingCamp.Data.Common.EntityValidationConstants.ProductValidations;

namespace WoodCarvingCamp.Web.ViewModels.Shop
{
    public class ProductFormModel
    {
        public ProductFormModel()
        {
            Categories = new HashSet<CategoryViewModel>();
        }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        [Display(Name = "Product Description")]
        public string Description { get; set; } = null!;
        [Required]
        [Display(Name = "Product Price")]
        public decimal Price { get; set; }
        [Required]
        [StringLength(ImageUrlMaxLength)]
        [Display(Name = "Image Path")]
        public string ImageUrl { get; set; } = null!;
        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public DateTime UpdatedOn { get; set; }
        [Required]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        public IEnumerable<CategoryViewModel> Categories { get; set; }

	}
}
