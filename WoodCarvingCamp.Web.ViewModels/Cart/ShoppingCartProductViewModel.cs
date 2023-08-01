using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCarvingCamp.Web.ViewModels.Cart
{
    public class ShoppingCartProductViewModel
    {
        public int Id { get; set; }
        [Display(Name = "Product Name")]
        public string Name { get; set; } = null!;

        [Display(Name = "Product Price")]
        public decimal Price { get; set; }
    }
}
