using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.User;

namespace WoodCarvingCamp.Services.Data
{
    public class UserService : IUserService
    {
        private readonly WoodCarvingCampDbContext dbContext;

        public UserService(WoodCarvingCampDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<UserProfileViewModel> GetUserProfile(string id)
        {
            var user = await this.dbContext.Users
                .FirstAsync(u => u.Id.ToString() == id);

            if (user == null)
            {
                throw new ArgumentException("User does not exist!");
            }
            UserProfileViewModel model = new UserProfileViewModel()
            {
                Id = user.Id.ToString(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email
            };
            return model;
        }
    }
}
