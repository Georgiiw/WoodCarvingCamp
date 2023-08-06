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
        public Comment Comment { get; set; } = null!;

    }
}
