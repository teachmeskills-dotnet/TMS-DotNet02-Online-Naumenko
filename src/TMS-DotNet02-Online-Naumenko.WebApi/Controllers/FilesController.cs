using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;
using TMS_DotNet02_Online_Naumenko.WebApi.Mappers;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FilesController(IFileService fileService)
        {
            _fileService = fileService ?? throw new ArgumentNullException(nameof(fileService));
        }

        [HttpPost]
        public IActionResult Add(FileViewModel post)
        {
            if (post == null || post.Id <= 0)
            {
                return BadRequest();
            }

            _fileService.Add(post.MapToDto());

            return Created("~posts", post);
        }

        [HttpGet]
        public IActionResult Get(string? title = null, int? userId = null, [FromQuery] int[]? termIds = null)
        {
            FilterViewModel filter = new FilterViewModel
            {
                Title = title,
                UserId = userId,
                TermIds = termIds.ToList(),
            };

            return Ok(_fileService.Get(filter.MapToDto()).MapToView());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            return Ok(_fileService.GetById(id).MapToView());
        }

        [HttpPut]
        public IActionResult Udpate(FileViewModel post)
        {
            if (post == null || post.Id <= 0)
            {
                return BadRequest();
            }

            _fileService.Update(post.MapToDto());

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            _fileService.Delete(id);

            return NoContent();
        }
    }
}
