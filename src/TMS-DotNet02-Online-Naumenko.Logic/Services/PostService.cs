using Microsoft.EntityFrameworkCore;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository;
using TMS_DotNet02_Online_Naumenko.Logic.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;

        public PostService(IRepository<Post> postRepository)
        {
            _postRepository = postRepository ?? throw new ArgumentNullException(nameof(postRepository));
        }

        public IEnumerable<PostDTO> GetAllPosts() =>
            

        public Task<IEnumerable<PostDTO>> GetAllPostsByTermIdsAsync(IEnumerable<int> termId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostDTO>> GetAllPostsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<PostDTO> GetPostByIdAsync()
        {
            throw new NotImplementedException();
        }
    }
}
