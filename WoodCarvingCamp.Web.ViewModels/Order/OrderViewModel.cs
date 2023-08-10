using System.ComponentModel.DataAnnotations;

using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Web.ViewModels.Cart;

namespace WoodCarvingCamp.Web.ViewModels.Order
{
    public class OrderViewModel
    {
        public OrderViewModel()
        {
            Products = new HashSet<ShoppingCartProductViewModel>();
        }
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Total Price")]
        public decimal TotalPrice { get; set; }
        [Display(Name = "Order Status")]
        public string OrderStatus { get; set; } = null!;
        [Display(Name = "Payment Status")]
        public string PaymentStatus { get; set; } = null!;
        [Display(Name = "Transaction")]
        public string TransactionId { get; set; } = null!;
        public ICollection<ShoppingCartProductViewModel> Products { get; set; }
    }
}
