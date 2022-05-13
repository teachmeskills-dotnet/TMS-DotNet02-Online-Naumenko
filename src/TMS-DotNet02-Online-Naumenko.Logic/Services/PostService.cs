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

        public PostDto GetById(int id)
        {
            // _postRepository.Delete(id);
            return _postRepository.GetById(id).MapToDto();
        }

        public void DeletePost(int id)
        {
            _postRepository.Delete(id);
            _postRepository.SaveChangesAsync();
        }

        public async Task UpdatePost(PostDto postDto)
        {
            postDto = postDto ?? throw new ArgumentNullException(nameof(postDto));

            var post = await _postRepository.GetEntityAsync(post => post.Id == postDto.Id);

            post.Title = postDto.Title;
            post.Slug = postDto.Slug;
            post.Content = postDto.Content;
            post.Excerpt = postDto.Excerpt;
            post.ReadingTime = postDto.ReadingTime;
            post.Date = postDto.Date;
            post.ModificationDate = postDto.ModificationDate;
            post.PostStatusId = postDto.PostStatusId;

            await _postRepository.SaveChangesAsync();
        }
    }
}
