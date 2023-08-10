using System.ComponentModel.DataAnnotations;

using static WoodCarvingCamp.Data.Common.EntityValidationConstants.GalleryPhotoValidations;

namespace WoodCarvingCamp.Data.Models
{
    public class GalleryPhoto
    {
        public GalleryPhoto()
        {
            this.Comments = new HashSet<Comment>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;
        public ICollection<Comment> Comments { get; set; }

        [Required]
        public DateTime CreatedOn { get; set; }
    }
}
