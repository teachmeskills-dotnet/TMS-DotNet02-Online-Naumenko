﻿using Microsoft.EntityFrameworkCore;
using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Data.Repository;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;

        public PostService(IRepository<Post> postRepository)
        {
            _postRepository = postRepository ?? throw new ArgumentNullException(nameof(postRepository));
        }

        public IEnumerable<PostDto> GetAllPosts()
        {
            return _postRepository.GetAll().MapToDto();
        }

        public Task<PostDto> GetPostByIdAsync(int postId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostDto>> GetAllPostsByTermIdsAsync(IEnumerable<int> termId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostDto>> GetAllPostsByUserIdAsync(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
