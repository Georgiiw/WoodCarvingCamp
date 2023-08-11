
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Tests.Mocks;
using WoodCarvingCamp.Web.ViewModels.Order;

namespace WoodCarvingCamp.Tests
{
    [TestFixture]
    public class OrderServiceTest
    {
        private IOrderService orderService;

        [Test]
        public async Task AddOrderAsync()
        {
            using var data = DbMock.Instance;
            this.orderService = new OrderService(data);
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var cartItems = new List<CartItem>();
            var model = new OrderViewModel()
            {
                Id = 1,
                OrderStatus = "successful",
                PaymentStatus = "successful",
                CreatedOn = DateTime.Now,
                TransactionId = "trId",
                TotalPrice = 50.00m,               
            };
            Order order = new Order()
            {
                Id = model.Id,
                User = user,
                OrderStatus = model.OrderStatus,
                PaymentStatus = model.PaymentStatus,
                TransactionId = model.TransactionId,
                TotalPrice = model.TotalPrice,
                CreatedOn = model.CreatedOn,
                CartItems = cartItems
            };
            await data.Orders.AddAsync(order);
            await data.Users.AddAsync(user);
            await data.SaveChangesAsync();

            await this.orderService.AddOrderAsync(model, user.Id.ToString());
            var dbOrder = data.Orders.FirstOrDefault(o => o.Id == 1);

            Assert.That(dbOrder, Is.Not.Null);
        }
        [Test]
        public async Task AddOrderAsyncInvalidUserId()
        {
            using var data = DbMock.Instance;
            this.orderService = new OrderService(data);
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var cartItems = new List<CartItem>();
            var model = new OrderViewModel()
            {
                Id = 1,
                OrderStatus = "successful",
                PaymentStatus = "successful",
                CreatedOn = DateTime.Now,
                TransactionId = "trId",
                TotalPrice = 50.00m,
            };
            Order order = new Order()
            {
                Id = model.Id,
                User = user,
                OrderStatus = model.OrderStatus,
                PaymentStatus = model.PaymentStatus,
                TransactionId = model.TransactionId,
                TotalPrice = model.TotalPrice,
                CreatedOn = model.CreatedOn,
                CartItems = cartItems
            };
            await data.Orders.AddAsync(order);
            await data.Users.AddAsync(user);
            await data.SaveChangesAsync();

            this.orderService = new OrderService(data);

            var exception = Assert.ThrowsAsync<ArgumentException>(
               async () => await this.orderService.AddOrderAsync(model, "2"));

            Assert.That(exception.Message, Is.EqualTo("User Not Found!"));
        }
        [Test]
        public async Task UpdateOrderAsync()
        {
            using var data = DbMock.Instance;
            this.orderService = new OrderService(data);
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var cartItems = new List<CartItem>();
            var model = new OrderViewModel()
            {
                Id = 1,
                OrderStatus = "successful",
                PaymentStatus = "successful",
                CreatedOn = DateTime.Now,
                TransactionId = "trId",
                TotalPrice = 50.00m,
            };
            Order order = new Order()
            {
                Id = model.Id,
                User = user,
                OrderStatus = "pending",
                PaymentStatus = model.PaymentStatus,
                TransactionId = model.TransactionId,
                TotalPrice = model.TotalPrice,
                CreatedOn = model.CreatedOn,
                CartItems = cartItems
            };
            await data.Orders.AddAsync(order);
            await data.Users.AddAsync(user);
            await data.SaveChangesAsync();

            await this.orderService.UpdateOrderAsync(model);
            var dbOrder = data.Orders.FirstOrDefault(o => o.Id == 1);

            Assert.That(dbOrder.OrderStatus, Is.EqualTo("successful"));
        }
    }
}
