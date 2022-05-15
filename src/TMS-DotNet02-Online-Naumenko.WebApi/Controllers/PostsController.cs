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
        public async Task CreatePost(PostDto post)
        {
            Console.WriteLine("Suc");
            await _postService.CreatePost(post);
        }

        [HttpGet]
        public IEnumerable<PostDto> GetAll(string? title = null, int? userId = null, [FromQuery]int[]? termIds = null)
        {
            if (termIds != null)
            {
                throw new ArgumentNullException(nameof(title));
            }
            FilterDto filter = new FilterDto
            {
                Title = title,
                UserId = userId,
                TermsId = termIds.ToList(),
            };

            return _postService.GetAll(filter);
        }

        [HttpGet("{id}")]
        public PostDto GetById(int id)
        {
            return _postService.GetById(id);
        }

        public void DeletePost(int id)
        {
            _postService.DeletePost(id);
        }
    }
}
