using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService ?? throw new ArgumentNullException(nameof(postService));
        }

        public PostDto TestData()
        {
            return new PostDto {
                Id = 6,
                /*Title = "test 1",
                Slug = "test 1",
                Content = "test 1",
                UserId = 2,
                TypeId = 1,
                PostStatusId = (Data.Models.Enums.PostStatus)1,*/
            };
        }

        // [HttpPost]
        public async Task CreatePost(/*PostDto post*/)
        {
            Console.WriteLine("Suc");
            await _postService.CreatePost(TestData());
        }

        [HttpGet]
        public IEnumerable<PostDto> GetAll()
        {
            var result = _postService.GetAll();

            return result;
        }

        public void DeletePost(/*PostDto post*/)
        {
            _postService.DeletePost(TestData());
        }
    }
}
