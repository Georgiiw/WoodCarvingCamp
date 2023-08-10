using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data.Models;

namespace WoodCarvingCamp.Web.ViewModels.UserComment
{
    public class CommentViewModel
    {
		public int Id { get; set; }		
		public DateTime CreatedOn { get; set; }
		public string Description { get; set; } = null!;
		public string CreatorId { get; set; } = null!;
		public string CreatorName { get; set; } = null!;

	}
}
