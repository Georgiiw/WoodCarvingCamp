using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCarvingCamp.Data.Models
{
    public class CartItem
    {
        public CartItem()
        {
            ShoppingCart = new HashSet<ShoppingCart>();
        }

        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public int Quantity { get; set; }
        public ICollection<ShoppingCart> ShoppingCart { get; set; }

    }
}
