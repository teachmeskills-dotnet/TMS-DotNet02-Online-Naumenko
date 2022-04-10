using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository;
using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _postRepository;

        public PostService(IPostRepository postRepository)
        {
            _postRepository = postRepository ?? throw new ArgumentNullException(nameof(postRepository));
        }

        public IEnumerable<PostDto> GetAll(FilterDto filter)
        {
            return _postRepository.GetAll(filter.MapDtoTo()).MapToDto();
        }

        public async Task CreatePost(PostDto post)
        {
            await _postRepository.AddAsync(post.MapDtoTo());
            await _postRepository.SaveChangesAsync();
        }

        public void DeletePost(int id)
        {
            _postRepository.Delete(id);
            _postRepository.SaveChangesAsync();
        }
    }
}
