using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class PostMappers
    {
        public static PostDto MapToDto(this PostViewModel post)
        {
            return new PostDto
            {
                Id = post.Id,
                TypeId = post.TypeId,
                Title = post.Title,
                Slug = post.Slug,
                Content = post.Content,
                Excerpt = post.Excerpt,
                ReadingTime = post.ReadingTime,
                Date = post.Date,
                ModificationDate = post.ModificationDate,
                PostStatusId = post.PostStatusId,
                UserId = post.UserId,
            };
        }

        public static IEnumerable<PostViewModel> MapToView(this IEnumerable<PostDto> posts)
        {
            foreach (var post in posts)
            {
                yield return new PostViewModel
                {
                    Id = post.Id,
                    TypeId = post.TypeId,
                    Title = post.Title,
                    Slug = post.Slug,
                    Content = post.Content,
                    Excerpt = post.Excerpt,
                    ReadingTime = post.ReadingTime,
                    Date = post.Date,
                    ModificationDate = post.ModificationDate,
                    PostStatusId = post.PostStatusId,
                    UserId = post.UserId,
                };
            }
        }

        public static PostViewModel MapToView(this PostDto post)
        {
            return new PostViewModel
            {
                Id = post.Id,
                TypeId = post.TypeId,
                Title = post.Title,
                Slug = post.Slug,
                Content = post.Content,
                Excerpt = post.Excerpt,
                ReadingTime = post.ReadingTime,
                Date = post.Date,
                ModificationDate = post.ModificationDate,
                PostStatusId = post.PostStatusId,
                UserId = post.UserId,
            };
        }
    }
}
