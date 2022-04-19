using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IPostService
    {
        IEnumerable<PostDto> GetAll(FilterDto filterDto);

        Task CreatePost(PostDto post);

        void DeletePost(int id);

        Task UpdatePost(PostDto postDto);
    }
}
