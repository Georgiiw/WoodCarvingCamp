using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Web.ViewModels.UserComment;

namespace WoodCarvingCamp.Web.ViewModels.GalleryPhoto
{
    public class GalleryPhotoViewModel
    {
        public GalleryPhotoViewModel()
        {
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public ICollection<Comment> Comments { get; set; }
    }
}
