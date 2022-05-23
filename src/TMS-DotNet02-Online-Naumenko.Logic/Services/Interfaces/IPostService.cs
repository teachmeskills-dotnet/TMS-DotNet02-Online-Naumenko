using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IPostService
    {
        Task Add(PostDto postDto);

        IEnumerable<PostDto> Get(FilterDto filterDto);

        PostDto GetById(int id);

        Task Update(PostDto postDto);

        void Delete(int id);
    }
}
