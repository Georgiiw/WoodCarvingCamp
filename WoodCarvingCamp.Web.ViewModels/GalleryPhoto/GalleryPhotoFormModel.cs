using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data.Models;
using static WoodCarvingCamp.Data.Common.EntityValidationConstants.GalleryPhotoValidations;

namespace WoodCarvingCamp.Web.ViewModels.GalleryPhoto
{
    public class GalleryPhotoFormModel
    {
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;
        [Required]
        public string ImageUrl { get; set; } = null!;
        [Required]
        public DateTime CreatedOn { get; set; }
        
    }
}
