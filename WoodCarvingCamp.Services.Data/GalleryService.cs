using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.GalleryPhoto;

namespace WoodCarvingCamp.Services.Data
{
    public class GalleryService : IGalleryService
    {
        private readonly WoodCarvingCampDbContext dbContext;

        public GalleryService(WoodCarvingCampDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddPhotoAsync(GalleryPhotoFormModel model)
        {
            GalleryPhoto newPhoto = new GalleryPhoto
            {
                Description = model.Description,
                ImageUrl = model.ImageUrl,
                CreatedOn = DateTime.Now
            };

            await this.dbContext.AddAsync(newPhoto);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
