using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Web.ViewModels.UserComment;

namespace WoodCarvingCamp.Web.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly ICommentService commentService;

        public CommentController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        [HttpPost]
        public async Task<IActionResult> Add(CommentFormModel model, [FromRoute] int id)
        {
            var userId = this.User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;

            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            try
            {
                await this.commentService.AddCommentToPhotoAsync(model, userId, id);
            }
            catch (Exception)
            {

                throw;
            }

            return RedirectToAction("Index", "Gallery");
        }
    }
}
