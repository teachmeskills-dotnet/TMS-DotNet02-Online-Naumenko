using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Data.Interfaces;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mangers
{
    public class PostManager : IPostManager
    {
        private readonly IRepository<Post> _postRepository;

        private IQueryable<Post> PostQuery =>
                    _postRepository.GetAll();

        public PostManager(IRepository<Post> postRepository)
        {
            _postRepository = postRepository ?? throw new ArgumentNullException(nameof(postRepository));
        }

        public async Task<IEnumerable<PostDTO>> GetAllPostsAsync() =>
            GetPosts(await PostQuery.ToListAsync());

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

        private static IEnumerable<PostDTO> GetPosts(IEnumerable<Post> posts)
        {
            foreach (var post in posts)
            {
                yield return new PostDTO
                {
                    Title = post.Title,
                };
            }
        }
    }
}
