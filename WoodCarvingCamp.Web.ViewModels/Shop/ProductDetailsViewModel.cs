using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCarvingCamp.Web.ViewModels.Shop
{
    public class ProductDetailsViewModel : AllProductsViewModel
    {
        public string Category { get; set; } = null!;
    }
}
