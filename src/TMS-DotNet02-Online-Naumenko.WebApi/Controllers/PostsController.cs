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

        [HttpGet]
        public IEnumerable<PostDto> GetAll()
        {
            var result =  _postService.GetAllPosts();

            return result;
        }

        [HttpGet("{id}")]
        public IEnumerable<PostDto> GetById(int id)
        {
            var result = _postService.GetAllPosts();

            return result;
        }

        [HttpPost]
        public IEnumerable<PostDto> CreatePost(int id)
        {
            var result = _postService.AddAsync();

            return result;
        }
    }
}
