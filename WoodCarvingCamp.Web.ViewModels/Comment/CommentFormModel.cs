using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static WoodCarvingCamp.Data.Common.EntityValidationConstants.CommentValidations;

namespace WoodCarvingCamp.Web.ViewModels.UserComment
{
    public class CommentFormModel
    {
       
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength)]
        public string Description { get; set; } = null!;
       

    }
}
