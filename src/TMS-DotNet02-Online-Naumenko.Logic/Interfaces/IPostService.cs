using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Interfaces
{
    public interface IPostService
    {
        Task<PostDTO> GetPostByIdAsync();

        IEnumerable<PostDTO> GetAllPosts();

        Task<IEnumerable<PostDTO>> GetAllPostsByUserIdAsync(int userId);

        Task<IEnumerable<PostDTO>> GetAllPostsByTermIdsAsync(IEnumerable<int> termId);
    }
}
