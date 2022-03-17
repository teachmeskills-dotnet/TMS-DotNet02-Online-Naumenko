using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IPostService
    {
        Task<PostDto> GetPostByIdAsync();

        IEnumerable<PostDto> GetAllPosts();

        Task<IEnumerable<PostDto>> GetAllPostsByUserIdAsync(int userId);

        Task<IEnumerable<PostDto>> GetAllPostsByTermIdsAsync(IEnumerable<int> termId);
    }
}
