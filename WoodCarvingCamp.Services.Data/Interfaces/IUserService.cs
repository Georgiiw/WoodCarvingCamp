using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Web.ViewModels.User;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface IUserService
    {
        Task<UserProfileViewModel> GetUserProfile(string iD);
    }
}
