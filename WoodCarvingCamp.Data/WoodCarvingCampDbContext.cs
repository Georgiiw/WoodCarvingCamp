using HouseRentingSystem.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WoodCarvingCamp.Data
{
    public class WoodCarvingCampDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public WoodCarvingCampDbContext(DbContextOptions<WoodCarvingCampDbContext> options)
            : base(options)
        {

        }
    }
}