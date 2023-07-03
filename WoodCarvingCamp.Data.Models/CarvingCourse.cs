﻿using System.ComponentModel.DataAnnotations;

using static WoodCarvingCamp.Data.Common.EntityValidationConstants.CarvingCourseValidations;

namespace WoodCarvingCamp.Data.Models
{
    public class CarvingCourse
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(ImageUrlMaxLength)]
        public string ImageUrl { get; set; } = null!;

        [Required]
        public bool IsPaid { get; set; }

        public decimal? Price { get; set; }

        [Required]
        public DateTime AddedOn { get; set; }

    }
}
