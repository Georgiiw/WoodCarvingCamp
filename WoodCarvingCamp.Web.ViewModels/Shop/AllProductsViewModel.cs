using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data.Models;

namespace WoodCarvingCamp.Web.ViewModels.Shop
{
    public class AllProductsViewModel
    {
        public int Id { get; set; }
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
