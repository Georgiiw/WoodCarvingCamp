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


            var user = await this.dbContext
               .Users
               .Where(u => u.Id.ToString() == userId)
               .Include(sc => sc.ShoppingCart)
               .ThenInclude(c => c.Products)
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
           
            user.ShoppingCart.Products.Add(product);
            await this.dbContext.SaveChangesAsync();

        }

        public async Task<ShoppingCartViewModel> GetShoppingCart(string userId)
        {
            var user = await this.dbContext
                .Users
                .Where(u => u.Id.ToString() == userId)
                .Include(sc => sc.ShoppingCart)
                .ThenInclude(c => c.Products)              
                .FirstOrDefaultAsync();

            if (user == null || user.ShoppingCartId == null)
            {
                 return null;
            }

            var products = user.ShoppingCart?.Products
                .Select(p => new ShoppingCartProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList();

            var cart = new ShoppingCartViewModel()
            {
                Products = products
            };

            return cart;

        }
    }
}
