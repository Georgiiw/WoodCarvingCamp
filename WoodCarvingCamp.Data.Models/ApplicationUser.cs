using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static WoodCarvingCamp.Data.Common.EntityValidationConstants.UserValidations;
namespace WoodCarvingCamp.Data.Models
{
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

        [Required]
        [StringLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;
        public virtual ICollection<CarvingCourse> CarvingCourses { get; set; }

        [ForeignKey(nameof(ShoppingCart))]
        public int? ShoppingCartId { get; set; }
        public ShoppingCart? ShoppingCart { get; set; }

    }
}