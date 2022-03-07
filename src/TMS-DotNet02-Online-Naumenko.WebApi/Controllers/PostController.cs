using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostManager _postManager;

        public PostController(IPostManager postManager)
        {
            _postManager = postManager ?? throw new ArgumentNullException(nameof(postManager));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _postManager.GetAllPostsAsync();

            return (IActionResult)result;
        }
    }
}
