using System.ComponentModel.DataAnnotations;

using static WoodCarvingCamp.Data.Common.EntityValidationConstants.CategoryValidations;

namespace WoodCarvingCamp.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;
    }
}
