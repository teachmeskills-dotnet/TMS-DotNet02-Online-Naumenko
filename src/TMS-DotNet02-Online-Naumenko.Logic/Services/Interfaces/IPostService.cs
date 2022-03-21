using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAllPosts();

        Task<PostDto> GetPostByIdAsync(int postId);

        Task<IEnumerable<PostDto>> GetAllPostsByUserIdAsync(int userId);

        Task<IEnumerable<PostDto>> GetAllPostsByTermIdsAsync(IEnumerable<int> termId);
    }
}
