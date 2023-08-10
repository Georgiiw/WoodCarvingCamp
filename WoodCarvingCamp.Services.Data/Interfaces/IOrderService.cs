using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Web.ViewModels.Cart;
using WoodCarvingCamp.Web.ViewModels.Order;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface IOrderService
    {
        Task<int> AddOrderAsync(OrderViewModel model, string userId);
        Task UpdateOrderAsync(OrderViewModel model);
        Task<OrderViewModel> GetOrderById(int orderId);
        Task Order(string stripeToken, string? userId, OrderViewModel order);


    }
}
