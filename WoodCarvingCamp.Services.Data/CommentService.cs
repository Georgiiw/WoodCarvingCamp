using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Data;
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.UserComment;

namespace WoodCarvingCamp.Services.Data
{
    public class CommentService : ICommentService
    {
        private readonly WoodCarvingCampDbContext dbContext;

        public CommentService(WoodCarvingCampDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task AddCommentToPhotoAsync(CommentFormModel model, string userId, int photoId)
        {
           var photo = await this.dbContext.GalleryPhotos
                .Where(p => p.Id == photoId)
                .FirstOrDefaultAsync();

            if (photo == null)
            {
                throw new ArgumentException("No photo to comment!");
            }

            ApplicationUser? user = await this.dbContext
              .Users
              .Where(u => u.Id.ToString() == userId)
              .FirstOrDefaultAsync();
            if (user == null)
            {
                throw new ArgumentException("User does not exist!");
            }
            Comment comment = new Comment
            {
                CreatorId = user.Id,
                Creator = user,
                Description = model.Description,
                CreatedOn = DateTime.UtcNow,
                PhotoId = photo.Id,
            };

            photo.Comments.Add(comment);

            await this.dbContext.AddAsync(comment);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteComment(int photoId)
        {
           
            Comment? commentToDel = this.dbContext.Comments.FirstOrDefault(c => c.Id == photoId);
            if (commentToDel == null)
            {
                throw new ArgumentException("No comment to delete!");
            }
            
            this.dbContext.Remove(commentToDel);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
