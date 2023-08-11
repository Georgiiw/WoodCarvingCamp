using Microsoft.EntityFrameworkCore;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.Cart;
using WoodCarvingCamp.Web.ViewModels.Order;

namespace WoodCarvingCamp.Services.Data
{
    public class OrderService : IOrderService
    {
        private readonly WoodCarvingCampDbContext dbContext;

        public OrderService(WoodCarvingCampDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> AddOrderAsync(OrderViewModel model, string userId)
        {

            ApplicationUser? user =  this.dbContext
               .Users
               .FirstOrDefault(u => u.Id.ToString() == userId);
            if (user == null)
            {
                throw new ArgumentException("User Not Found!");
            }
            List<CartItem> cartItems = new List<CartItem>();

            foreach (var item in model.Products)
            {
                CartItem? itemToAdd = await this.dbContext.CartItems.FirstOrDefaultAsync(c => c.Id == item.Id);
                cartItems.Add(itemToAdd);
            }

            if (string.IsNullOrEmpty(model.TransactionId))
            {
                model.TransactionId = "none";
            }

            Order order = new Order()
            {
                User = user,
                OrderStatus = model.OrderStatus,
                PaymentStatus = model.PaymentStatus,
                TransactionId = model.TransactionId,
                TotalPrice = model.TotalPrice,
                CreatedOn = model.CreatedOn,
                CartItems = cartItems
            };
            await this.dbContext.AddAsync(order);
            await this.dbContext.SaveChangesAsync();
            return order.Id;
        }

        public async Task<OrderViewModel> GetOrderById(int orderId)
        {
            var order = await this.dbContext.Orders
                .Where(o => o.Id == orderId)
                .Include(o => o.CartItems)
                .Select(o => new OrderViewModel()
                {
                    Id = o.Id,
                    CreatedOn = o.CreatedOn,
                    OrderStatus = o.OrderStatus,
                    PaymentStatus = o.PaymentStatus,
                    TransactionId = o.TransactionId,
                    TotalPrice = o.TotalPrice,
                    Products = o.CartItems.Select(ci => new ShoppingCartProductViewModel()
                    {
                        Id = ci.Id,
                        Quantity = ci.Quantity,
                        Product = ci.Product
                    }).ToList()
                }).FirstOrDefaultAsync();

            return order;
        }

        public async Task Order(string stripeToken, string? userId, OrderViewModel order)
        {
            order.Id = await AddOrderAsync(order, userId);
            var options = new ChargeCreateOptions
            {
                Amount = Convert.ToInt32(order.TotalPrice * 100),
                Currency = "usd",
                Description = $"Order ID : {order.Id} ",
                Source = stripeToken,
            };

            var service = new ChargeService();
            Charge charge = service.Create(options);
            if (charge.Id == null)
            {
                order.PaymentStatus = "rejected";
            }
            else
            {
                order.TransactionId = charge.Id;
            }

            if (charge.Status.ToLower() == "succeeded")
            {
                order.PaymentStatus = "approved";
                order.OrderStatus = "approved";
                order.CreatedOn = DateTime.Now;
            }

            await UpdateOrderAsync(order);
        }
        public async Task UpdateOrderAsync(OrderViewModel model)
        {
            Order? order = await this.dbContext.Orders.FirstOrDefaultAsync(o => o.Id == model.Id);

            order.PaymentStatus = model.PaymentStatus;
            order.OrderStatus = model.OrderStatus;
            order.CreatedOn = model.CreatedOn;
            order.TransactionId = model.TransactionId;
            order.TotalPrice = model.TotalPrice;

            this.dbContext.Update(order);
            await this.dbContext.SaveChangesAsync();
        }

    
    }
}
