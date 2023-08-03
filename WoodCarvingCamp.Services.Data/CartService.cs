using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.Infrastructure.Extensions;
using WoodCarvingCamp.Web.ViewModels.Cart;

namespace WoodCarvingCamp.Services.Data
{
    public class CartService : ICartService
    {
        private readonly WoodCarvingCampDbContext dbContext;
       

        public CartService(WoodCarvingCampDbContext dbContext, UserManager<ApplicationUser> userManager,
            IHttpContextAccessor contextAccessor)
        {
            this.dbContext = dbContext;          
        }

        public async Task AddProductToCart(int productId, string userId)
        {
            Product? product = await this.dbContext.Products
                .FirstOrDefaultAsync(p => p.Id == productId);


            CartItem cartItem = new CartItem()
            {
                ProductId = product.Id,
                Quantity = 1,

            };
            cartItem.Product = product;
            cartItem.Product.Name = product.Name;
            cartItem.Product.Description = product.Description;
            cartItem.Product.Price = product.Price;           
            cartItem.Product.CategoryId = product.CategoryId;

            ApplicationUser? user = await this.dbContext
               .Users
               .Where(u => u.Id.ToString() == userId)
               .Include(sc => sc.ShoppingCart)
               .ThenInclude(c => c.CartItems)
               .ThenInclude(p => p.Product)
               .FirstOrDefaultAsync();

            if (product == null)
            {
                throw new ArgumentException("Product does not exists.");
            }

            if (user == null)
            {
                throw new ArgumentException("User does not exists.");
            }

            if (user.ShoppingCartId == null)
            {
                ShoppingCart shoppingCart = new ShoppingCart()
                {
                    UserId = user.Id,
                };
                user.ShoppingCart = shoppingCart;
                user.ShoppingCartId = shoppingCart.Id;
                await this.dbContext.AddAsync(shoppingCart);
            }
           
            if (user.ShoppingCart.CartItems.Where(c => c.ProductId == cartItem.ProductId).Any())
            {
                foreach (var item in user.ShoppingCart.CartItems.Where(p => p.ProductId == cartItem.ProductId))
                {
                    item.Quantity += 1;
                }               
            }
            else
            {
                user.ShoppingCart.CartItems.Add(cartItem);

            }
            await this.dbContext.SaveChangesAsync();

        }

        public async Task<ShoppingCartViewModel> GetShoppingCart(string userId)
        {
            var user = await this.dbContext
                .Users
                .Where(u => u.Id.ToString() == userId)
                .Include(sc => sc.ShoppingCart)
                .ThenInclude(c => c.CartItems)
                .ThenInclude(p => p.Product)
                .FirstOrDefaultAsync();

            if (user == null || user.ShoppingCartId == null)
            {
                 return null;
            }
            
            var cartItems = user.ShoppingCart?.CartItems
                .Select(p => new ShoppingCartProductViewModel
                {
                    Id = p.Id,
                    Product = p.Product,
                    Quantity = p.Quantity
                    
                }).ToList();

            var cart = new ShoppingCartViewModel()
            {
                CartItems = cartItems
            };

            return cart;

        }

        public async Task RemoveItemFromCart(int productId, string userId)
        {
            ApplicationUser? user = await this.dbContext
               .Users
               .Where(u => u.Id.ToString() == userId)
               .Include(sc => sc.ShoppingCart)
               .ThenInclude(c => c.CartItems)
               .ThenInclude(p => p.Product)
               .FirstOrDefaultAsync();

            if (user == null)
            {
                throw new ArgumentException("User does not exists.");

            }
            CartItem? item = user.ShoppingCart?.CartItems
                .FirstOrDefault(ci => ci.Id == productId);
            if (item == null)
            {
                throw new ArgumentException("Product does not exists.");
            }

            item.Quantity--;

            if (item.Quantity < 1)
            {
                this.dbContext.CartItems.Remove(item);               
            }

            await this.dbContext.SaveChangesAsync();
        }
    }
}
