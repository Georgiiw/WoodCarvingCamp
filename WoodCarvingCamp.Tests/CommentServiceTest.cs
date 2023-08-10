
using WoodCarvingCamp.Data.Models;
using WoodCarvingCamp.Services.Data;
using WoodCarvingCamp.Services.Data.Interfaces;
using WoodCarvingCamp.Tests.Mocks;
using WoodCarvingCamp.Web.ViewModels.UserComment;

namespace WoodCarvingCamp.Tests
{
    [TestFixture]
    public class CommentServiceTest
    {
        private ICommentService commentService;
        [Test]
        public async Task AddCommentToPhoto()
        {
            using var data = DbMock.Instance;
            this.commentService = new CommentService(data);

            var photo = new GalleryPhoto()
            {
                Id = 1,
                Title = "title",
                Description = "photo desc photo desc photo desc photo desc photo desc",
                ImageUrl = "imagePath",
                CreatedOn = DateTime.Now
            }; 
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var comment = new Comment()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",               
                CreatedOn = DateTime.UtcNow,
                CreatorName = $"{user.FirstName} {user.LastName}",
                PhotoId = photo.Id
            };
            var model = new CommentFormModel()
            {
                Description = comment.Description
            };

            data.Comments.Add(comment);
            await data.Users.AddAsync(user);
            await data.Comments.AddAsync(comment);
            await data.GalleryPhotos.AddAsync(photo);
            await data.SaveChangesAsync();

            await this.commentService.AddCommentToPhotoAsync(model, user.Id.ToString(), photo.Id);
            var dbComment = data.Comments.FirstOrDefault(c => c.PhotoId == 1);

            Assert.That(dbComment, Is.Not.Null);
        }
        [Test]
        public async Task AddCommentToPhotoInvalidUserId()
        {
            using var data = DbMock.Instance;
            this.commentService = new CommentService(data);

            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var photo = new GalleryPhoto()
            {
                Id = 1,
                Title = "title",
                Description = "photo desc photo desc photo desc photo desc photo desc",
                ImageUrl = "imagePath",
                CreatedOn = DateTime.Now
            };
            var comment = new Comment()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                CreatedOn = DateTime.UtcNow,
                CreatorName = $"{user.FirstName} {user.LastName}",
                PhotoId = photo.Id
            };
            var model = new CommentFormModel()
            {
                Description = comment.Description
            };
            data.Comments.Add(comment);


            await data.Users.AddAsync(user);
            await data.Comments.AddAsync(comment);
            await data.GalleryPhotos.AddAsync(photo);
            await data.SaveChangesAsync();
       
            var exception = Assert.ThrowsAsync<ArgumentException>(
               async () => await this.commentService.AddCommentToPhotoAsync(model,"1", 1));

            Assert.That(exception.Message, Is.EqualTo("User does not exist!"));
        }
        [Test]
        public async Task AddCommentToPhotoInvalidPhotoId()
        {
            using var data = DbMock.Instance;
            this.commentService = new CommentService(data);

            var photo = new GalleryPhoto()
            {
                Id = 1,
                Title = "title",
                Description = "photo desc photo desc photo desc photo desc photo desc",
                ImageUrl = "imagePath",
                CreatedOn = DateTime.Now
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var comment = new Comment()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                CreatedOn = DateTime.UtcNow,
                CreatorName = $"{user.FirstName} {user.LastName}",
                PhotoId = photo.Id
            };
            var model = new CommentFormModel()
            {
                Description = comment.Description
            };
            data.Comments.Add(comment);


            await data.Users.AddAsync(user);
            await data.Comments.AddAsync(comment);
            await data.GalleryPhotos.AddAsync(photo);
            await data.SaveChangesAsync();

            var exception = Assert.ThrowsAsync<ArgumentException>(
               async () => await this.commentService.AddCommentToPhotoAsync(model, user.Id.ToString(), 5));

            Assert.That(exception.Message, Is.EqualTo("No photo to comment!"));
        }
        [Test]
        public async Task DeleteCommentFromPhoto()
        {
            using var data = DbMock.Instance;
            this.commentService = new CommentService(data);

            var photo = new GalleryPhoto()
            {
                Id = 1,
                Title = "title",
                Description = "photo desc photo desc photo desc photo desc photo desc",
                ImageUrl = "imagePath",
                CreatedOn = DateTime.Now
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var comment = new Comment()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                CreatedOn = DateTime.UtcNow,
                CreatorName = $"{user.FirstName} {user.LastName}",
                PhotoId = photo.Id
            };
            var model = new CommentFormModel()
            {
                Description = comment.Description
            };
            data.Comments.Add(comment);


         
            await data.Users.AddAsync(user);
            await data.Comments.AddAsync(comment);
            await data.GalleryPhotos.AddAsync(photo);
            await data.SaveChangesAsync();

            await this.commentService.DeleteComment(1);
            var deletedCommnet = data.Comments.FirstOrDefault(c => c.Id == 1);

            Assert.That(deletedCommnet, Is.Null);
        }
        [Test]
        public async Task DeleteCommentFromPhotoInvalidCommentId()
        {
            using var data = DbMock.Instance;
            this.commentService = new CommentService(data);

            var photo = new GalleryPhoto()
            {
                Id = 1,
                Title = "title",
                Description = "photo desc photo desc photo desc photo desc photo desc",
                ImageUrl = "imagePath",
                CreatedOn = DateTime.Now
            };
            var user = new ApplicationUser()
            {
                Id = Guid.NewGuid(),
                FirstName = "pesho",
                LastName = "peshev",
                Email = "pesho@abv.bg",

            };
            var comment = new Comment()
            {
                Id = 1,
                Description = "My product desc! My product desc! My product desc! My product desc! ",
                CreatedOn = DateTime.UtcNow,
                CreatorName = $"{user.FirstName} {user.LastName}",
                PhotoId = photo.Id
            };
            var model = new CommentFormModel()
            {
                Description = comment.Description
            };
            data.Comments.Add(comment);


            await data.Users.AddAsync(user);
            await data.Comments.AddAsync(comment);
            await data.GalleryPhotos.AddAsync(photo);
            await data.SaveChangesAsync();


            var exception = Assert.ThrowsAsync<ArgumentException>(
               async () => await this.commentService.DeleteComment(5));

            Assert.That(exception.Message, Is.EqualTo("No comment to delete!"));
        }

    }
}
