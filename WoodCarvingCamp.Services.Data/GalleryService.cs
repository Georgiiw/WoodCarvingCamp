using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<GalleryPhotoViewModel>> AllPhotos()
        {
            IEnumerable<GalleryPhotoViewModel> photos = await dbContext
                .GalleryPhotos
                .Select(gp => new GalleryPhotoViewModel
                {
                    Id = gp.Id,                   
                    Description = gp.Description,
                    ImageUrl = gp.ImageUrl,
                    Comments = gp.Comments
                }).ToListAsync();

            return photos;
        }

        public async Task<bool> ExistsByIdAsync(string id)
        {
            bool result = await dbContext.GalleryPhotos
                .AnyAsync(p => p.Id.ToString() == id);

            return result;
        }

        public async Task<GalleryPhotoViewModel> GetDetailsByIdAsync(string id)
        {
            GalleryPhoto photo = await this.dbContext.GalleryPhotos
                .FirstAsync(p => p.Id.ToString() == id);

            return new GalleryPhotoViewModel
            {
                Id = photo.Id,
                Description = photo.Description,
                ImageUrl = photo.ImageUrl,
                Comments = photo.Comments
            };
        }
    }
}
