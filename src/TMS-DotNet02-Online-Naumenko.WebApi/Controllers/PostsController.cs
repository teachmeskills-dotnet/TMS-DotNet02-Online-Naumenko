using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService ?? throw new ArgumentNullException(nameof(postService));
        }

        [HttpPost]
        public string CreatePost(PostDto post)
        {
            var id = _postService.CreatePost(post);

            return $"Post added. Post id - {id}";
        }

        [HttpGet]
        public IEnumerable<PostDto> GetAll()
        {
            var result = _postService.GetAll();

            return result;
        }
    }
}
