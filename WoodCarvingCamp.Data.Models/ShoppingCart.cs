using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCarvingCamp.Data.Models
{
    public class ShoppingCart
    {
        public ShoppingCart()
        {
            this.CartItems = new HashSet<CartItem>();
        }      
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }
        [Required]
        public ApplicationUser? User { get; set; }

        public ICollection<CartItem> CartItems { get; set; }

    }
}
