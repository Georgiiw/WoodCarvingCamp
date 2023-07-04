namespace HouseRentingSystem.Data.Models
{
    using Microsoft.AspNetCore.Identity;
    using WoodCarvingCamp.Data.Models;

    /// <summary>
    /// This is custom user class that works with the default ASP.NET Core Identity.
    /// You can add additional info to the built-in users.
    /// </summary>
    public class ApplicationUser : IdentityUser<Guid>
    {
        public ApplicationUser()
        {
            this.Id = Guid.NewGuid();
            this.CarvingCourses = new HashSet<CarvingCourse>();
        }

        public virtual ICollection<CarvingCourse> CarvingCourses { get; set; }

    }
}