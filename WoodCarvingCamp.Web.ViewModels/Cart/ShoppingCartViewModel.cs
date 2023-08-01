using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data.Models;

namespace WoodCarvingCamp.Web.ViewModels.Cart
{
    public class ShoppingCartViewModel
    {
        public ShoppingCartViewModel()
        {
            this.Products = new List<ShoppingCartProductViewModel>();
        }      
        public ICollection<ShoppingCartProductViewModel> Products { get; set; }
    }
}
