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

        public async Task Add(PostDto postDto)
        {
            await _postRepository.AddAsync(postDto.MapToDomain());
            await _postRepository.SaveChangesAsync();
        }

        public IEnumerable<PostDto> Get(FilterDto filterDto)
        {
            return _postRepository.Get(filterDto.MapToDomain()).MapToDto();
        }

        public async Task<PostDto> GetById(int id)
        {
            return (await _postRepository.GetByIdAsync(post => post.Id == id)).MapToDto();
        }

        public async Task Update(PostDto postDto)
        {
            postDto = postDto ?? throw new ArgumentNullException(nameof(postDto));

            var post = await _postRepository.GetByIdAsync(post => post.Id == postDto.Id);

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

        public void Delete(int id)
        {
            _postRepository.Delete(id);
            _postRepository.SaveChangesAsync();
        }
    }
}
