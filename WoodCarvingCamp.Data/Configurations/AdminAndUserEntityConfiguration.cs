using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using WoodCarvingCamp.Data.Models;
using static WoodCarvingCamp.Common.AdminUserValidations.AdminValidations;

namespace WoodCarvingCamp.Data.Configurations
{
    public class AdminAndUserEntityConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasData(this.GenerateUsers());
        }
        private ApplicationUser[] GenerateUsers()
        {
            ICollection<ApplicationUser> users = new HashSet<ApplicationUser>();

            var hasher = new PasswordHasher<ApplicationUser>();
            ApplicationUser adminUser = new ApplicationUser()
            {
                FirstName = "Admin",
                LastName = "Adminov",
                Email = AdminEmail,
                NormalizedEmail = AdminEmail,
                NormalizedUserName = AdminEmail,
                UserName = AdminEmail,
                SecurityStamp = Guid.NewGuid().ToString()
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, "admin123");
            users.Add(adminUser);

            ApplicationUser basicUser = new ApplicationUser()
            {
                FirstName = "Stefcho",
                LastName = "Stefanov",
                Email = "stefcho@abv.bg",
                NormalizedEmail = "stefcho@abv.bg",
                NormalizedUserName = "stefcho@abv.bg",
                UserName = "stefcho@abv.bg",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            basicUser.PasswordHash = hasher.HashPassword(basicUser, "stefcho123");
            users.Add(basicUser);

            return users.ToArray();
        }
    }
}
