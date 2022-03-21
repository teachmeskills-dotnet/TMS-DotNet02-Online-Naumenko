using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class PostMappers
    {
        public static IEnumerable<PostDto> MapToDto(this IEnumerable<Post> posts)
        {
            foreach (var post in posts)
            {
                yield return new PostDto
                {
                    Id = post.Id,
                    TypeId = post.TypeId,
                    Title = post.Title,
                    Slug = post.Slug,
                    Content = post.Content,
                    Excerpt = post.Excerpt,
                    Date = post.Date,
                    ModificationDate = post.ModificationDate,
                    PostStatusId = post.PostStatusId,
                    UserId = post.UserId,
                };
            }
        }
    }
}
