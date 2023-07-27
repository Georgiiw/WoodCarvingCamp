using System.ComponentModel.DataAnnotations;

using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Web.ViewModels.Category;

namespace WoodCarvingCamp.Web.ViewModels.Shop
{
    public class AllProductsViewModel
    {
        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        [Display(Name = "Product Description")]
        public string Description { get; set; } = null!;
        [Display(Name = "Product Price")]
        public decimal Price { get; set; }
        [Display(Name = "Image Link")]
        public string ImageUrl { get; set; } = null!;
        public DateTime CreatedOn { get; set; }                
        public Discount? Discount { get; set; }
    }
}
