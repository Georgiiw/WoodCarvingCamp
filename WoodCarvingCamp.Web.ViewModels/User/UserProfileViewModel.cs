using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCarvingCamp.Web.ViewModels.User
{
    public class UserProfileViewModel
    {
        public string Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
    }
}
