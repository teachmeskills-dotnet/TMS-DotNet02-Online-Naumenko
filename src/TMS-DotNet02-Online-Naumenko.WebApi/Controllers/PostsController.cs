using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;
using TMS_DotNet02_Online_Naumenko.WebApi.Mappers;

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
        public IActionResult Create(PostViewModel post)
        {
            if (post == null || post.Id <= 0)
            {
                return BadRequest();
            }

            _postService.Add(post.MapToDto());

            return Created("~posts", post);
        }

        [HttpGet]
        public IActionResult Get(string? title = null, int? userId = null, [FromQuery]int[]? termIds = null)
        {
            FilterViewModel filter = new FilterViewModel
            {
                Title = title,
                UserId = userId,
                TermIds = termIds.ToList(),
            };

            return Ok(_postService.Get(filter.MapToDto()).MapToView());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            return Ok(_postService.GetById(id).MapToView());
        }

        [HttpPut]
        public IActionResult Udpate(PostViewModel post)
        {
            if (post == null || post.Id <= 0)
            {
                return BadRequest();
            }

            _postService.Update(post.MapToDto());

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            _postService.Delete(id);

            return NoContent();
        }
    }
}
