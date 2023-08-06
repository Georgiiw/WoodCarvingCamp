using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WoodCarvingCamp.Web.ViewModels.UserComment;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface ICommentService
    {
        Task AddCommentToPhotoAsync(CommentFormModel model, string userId, int photoId);
    }
}
