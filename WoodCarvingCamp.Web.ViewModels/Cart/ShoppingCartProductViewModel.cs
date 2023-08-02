using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data.Models;

namespace WoodCarvingCamp.Web.ViewModels.Cart
{
    public class ShoppingCartProductViewModel
    {
        public int Id { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
