﻿using WoodCarvingCamp.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using static WoodCarvingCamp.Data.Common.EntityValidationConstants.CommentValidations;

namespace WoodCarvingCamp.Data.Models
{
    public class Comment
    {
        public Comment()
        {
            GalleryPhotos = new HashSet<GalleryPhoto>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;   

        [ForeignKey(nameof(Creator))]
        public Guid CreatorId { get; set; }

        [Required]
        public virtual ApplicationUser Creator { get; set; } = null!;
		[Required]
        public string CreatorName { get; set; } = null!;

        [Required]
        public DateTime CreatedOn { get; set; }
        [Required]
        public int PhotoId { get; set; }
        public ICollection<GalleryPhoto> GalleryPhotos { get; set; }
    }
}
