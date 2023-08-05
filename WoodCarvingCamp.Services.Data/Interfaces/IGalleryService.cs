using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Web.ViewModels.GalleryPhoto;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface IGalleryService
    {
        Task AddPhotoAsync(GalleryPhotoFormModel model);
        Task<IEnumerable<GalleryPhotoViewModel>> AllPhotos();
        Task<GalleryPhotoViewModel> GetDetailsByIdAsync(string id);
        Task<bool> ExistsByIdAsync(string id);
    }
}
