using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Web.ViewModels.Shop.Enums;

namespace WoodCarvingCamp.Web.ViewModels.Shop
{
    public class AllProductsQuerryModel
    {
        public AllProductsQuerryModel()
        {
            this.Categories = new HashSet<string>();
            this.Products = new HashSet<AllProductsViewModel>();
        }
        public string? Category { get; set; }

        [Display(Name = "Sort by:")]
        public ProductSorting ProductSorting { get; set; }
        public IEnumerable<string> Categories { get; set; }
        public IEnumerable<AllProductsViewModel> Products { get; set; }
        public int TotalProducts { get; set; }
    }
}
