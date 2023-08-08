
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Tests.Mocks;

namespace WoodCarvingCamp.Tests
{
    [TestFixture]
    public class CartServiceTest
    {
        private ICartService cartService;
      
        [Test]
        public async Task AddProductToCartIfUserAndProductExists()
        {
            using var data = DbMock.Instance;

            var item = new Product()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                ImageUrl = "imagePath",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                Name = "carving knife",
                Price = 15.10m,
            };
            data.Products.Add(item);

         
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",
              
            };           
            data.Users.Add(user);
            data.SaveChanges();

            this.cartService = new CartService(data);

           await this.cartService.AddProductToCart(1, user.Id.ToString());

            var dbCart = data.ShoppingCarts.Where(s => s.Id == 1);
            var userWithItemInCart = data.Users.Where(u => u.ShoppingCart.CartItems.Any());
            
            Assert.That(dbCart != null);
            Assert.That(userWithItemInCart != null);
        }
        [Test]
        public async Task AddProductToCartInvalidUserIdExepction()
        {
            using var data = DbMock.Instance;

            var item = new Product()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                ImageUrl = "imagePath",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                Name = "carving knife",
                Price = 15.10m,
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",
            };
            await data.Users.AddAsync(user);
            await data.Products.AddAsync(item);

            await data.SaveChangesAsync();

            this.cartService = new CartService(data);

            var exception = Assert.ThrowsAsync<ArgumentException>(
               async () =>await this.cartService.AddProductToCart(1, "2"));

            Assert.That(exception.Message, Is.EqualTo("User does not exists."));
        }
        [Test]
        public async Task AddProductToCartInvalidProductIdException()
        {
            using var data = DbMock.Instance;
            this.cartService = new CartService(data);

            var item = new Product()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                ImageUrl = "imagePath",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                Name = "carving knife",
                Price = 15.10m,
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",
            };

            await data.Users.AddAsync(user);
            await data.Products.AddAsync(item);

            await data.SaveChangesAsync();
            var exception = Assert.ThrowsAsync<ArgumentException>(
              async () => await this.cartService.AddProductToCart(2, user.Id.ToString()));

            Assert.That(exception.Message, Is.EqualTo("Product does not exists."));
        }
        [Test]
        public async Task DecreaseCartItemQuantity()
        {
            using var data = DbMock.Instance;
            this.cartService = new CartService(data);

            var item = new Product()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                ImageUrl = "imagePath",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                Name = "carving knife",
                Price = 15.10m,
            };
            var cartitem = new CartItem()
            {
                Id = 1,
                ProductId = item.Id,
                Quantity = 2
            };
            var cartitems = new List<CartItem>();
            cartitems.Add(cartitem);

            var cart = new ShoppingCart()
            {
                Id = 1,
                CartItems = cartitems
            }; 
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",
                ShoppingCartId = cart.Id
            };
            cart.UserId = user.Id;

            await data.Users.AddAsync(user);
            await data.Products.AddAsync(item);
            await data.CartItems.AddAsync(cartitem);
            await data.ShoppingCarts.AddAsync(cart);

            await data.SaveChangesAsync();
            var deletedItem = user.ShoppingCart.CartItems.FirstOrDefault(p => p.Id == item.Id);
            await this.cartService.RemoveItemFromCart(item.Id, user.Id.ToString());
            Assert.That(deletedItem.Quantity == 1);
        }
        [Test]
        public async Task DeleteItemFromCart()
        {
            using var data = DbMock.Instance;
            this.cartService = new CartService(data);

            var item = new Product()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                ImageUrl = "imagePath",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                Name = "carving knife",
                Price = 15.10m,
            };
            var cartitem = new CartItem()
            {
                Id = 1,
                ProductId = item.Id,
                Quantity = 1
            };
            var cartitems = new List<CartItem>();
            cartitems.Add(cartitem);

            var cart = new ShoppingCart()
            {
                Id = 1,
                CartItems = cartitems
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",
                ShoppingCartId = cart.Id
            };
            cart.UserId = user.Id;

            await data.Users.AddAsync(user);
            await data.Products.AddAsync(item);
            await data.CartItems.AddAsync(cartitem);
            await data.ShoppingCarts.AddAsync(cart);

            await data.SaveChangesAsync();
            await this.cartService.RemoveItemFromCart(item.Id, user.Id.ToString());
            bool itemsInCart = user.ShoppingCart.CartItems.Any();
            Assert.That(itemsInCart == false);
        }
        [Test]
        public async Task DeleteItemFromCartInvalidUserId()
        {
            using var data = DbMock.Instance;
            this.cartService = new CartService(data);

            var item = new Product()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                ImageUrl = "imagePath",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                Name = "carving knife",
                Price = 15.10m,
            };
            var cartitem = new CartItem()
            {
                Id = 1,
                ProductId = item.Id,
                Quantity = 1
            };
            var cartitems = new List<CartItem>();
            cartitems.Add(cartitem);

            var cart = new ShoppingCart()
            {
                Id = 1,
                CartItems = cartitems
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",
                ShoppingCartId = cart.Id
            };
            cart.UserId = user.Id;

            await data.Users.AddAsync(user);
            await data.Products.AddAsync(item);
            await data.CartItems.AddAsync(cartitem);
            await data.ShoppingCarts.AddAsync(cart);

            await data.SaveChangesAsync();

            var exception = Assert.ThrowsAsync<ArgumentException>(
              async () => await this.cartService.RemoveItemFromCart(1, "2"));

            Assert.That(exception.Message, Is.EqualTo("User does not exists."));
        }
        [Test]
        public async Task DeleteItemFromCartInvalidProductId()
        {
            using var data = DbMock.Instance;
            this.cartService = new CartService(data);

            var item = new Product()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                ImageUrl = "imagePath",
                CategoryId = 1,
                CreatedOn = DateTime.UtcNow,
                Name = "carving knife",
                Price = 15.10m,
            };
            var cartitem = new CartItem()
            {
                Id = 1,
                ProductId = item.Id,
                Quantity = 1
            };
            var cartitems = new List<CartItem>();
            cartitems.Add(cartitem);

            var cart = new ShoppingCart()
            {
                Id = 1,
                CartItems = cartitems
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",
                ShoppingCartId = cart.Id
            };
            cart.UserId = user.Id;

            await data.Users.AddAsync(user);
            await data.Products.AddAsync(item);
            await data.CartItems.AddAsync(cartitem);
            await data.ShoppingCarts.AddAsync(cart);

            await data.SaveChangesAsync();

            var exception = Assert.ThrowsAsync<ArgumentException>(
              async () => await this.cartService.RemoveItemFromCart(5, user.Id.ToString()));

            Assert.That(exception.Message, Is.EqualTo("Product does not exists."));
        }
    }
}
