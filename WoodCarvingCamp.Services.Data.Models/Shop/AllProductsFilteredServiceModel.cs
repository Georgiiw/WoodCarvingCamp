using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Web.ViewModels.Shop;

namespace WoodCarvingCamp.Services.Data.Models.Shop
{
    public class AllProductsFilteredServiceModel
    {
        public AllProductsFilteredServiceModel()
        {
            this.Products = new HashSet<AllProductsViewModel>();
        }
        public int TotalProductsCount { get; set; }
        public IEnumerable<AllProductsViewModel> Products { get; set; }
    }
}
