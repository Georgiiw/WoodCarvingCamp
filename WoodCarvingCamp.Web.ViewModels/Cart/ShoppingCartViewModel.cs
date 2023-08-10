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
            this.CartItems = new List<ShoppingCartProductViewModel>();
        }      
        public ICollection<ShoppingCartProductViewModel> CartItems { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
