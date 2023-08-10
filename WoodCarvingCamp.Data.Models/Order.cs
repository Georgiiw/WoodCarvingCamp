using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WoodCarvingCamp.Data.Common.EntityValidationConstants.OrderValidations;
namespace WoodCarvingCamp.Data.Models
{
    public class Order
    {
        public Order()
        {
            CartItems = new HashSet<CartItem>();
        }
        [Required]  
        public int Id { get; set; }
        [Required]
        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public ApplicationUser User { get; set; } = null!;
        public DateTime CreatedOn { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }
        [Required]
        [MaxLength(OrderStatusMaxLength)]
        public string OrderStatus { get; set; } = null!;
        [Required]
        [MaxLength(PaymentStatusMaxLength)]
        public string PaymentStatus { get; set; } = null!;

        [Required]
        [MaxLength(TransactionIdMaxLength)]
        public string TransactionId { get; set; } = null!;
        public ICollection<CartItem> CartItems { get; set; }

    }
}
