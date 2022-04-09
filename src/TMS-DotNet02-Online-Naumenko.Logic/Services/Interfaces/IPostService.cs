using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAll();

        IEnumerable<PostDto> GetAll(int userId);

        Task CreatePost(PostDto post);

        void DeletePost(int id);
    }
}
