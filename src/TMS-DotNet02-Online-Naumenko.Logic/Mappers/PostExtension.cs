using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class PostExtension
    {
        public static IEnumerable<PostDTO> MapToDto(this IEnumerable<Post> posts)
        {
            foreach (var post in posts)
            {
                yield return new PostDTO
                {
                    Id = post.Id,
                    Title = post.Title,
                    Content = post.Content,
                };
            }
        }
    }
}
