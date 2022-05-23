using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;
using TMS_DotNet02_Online_Naumenko.WebApi.Mappers;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
        }

        [HttpPost]
        public IActionResult Create(UserViewModel term)
        {
            if (term == null || term.Id <= 0)
            {
                return BadRequest();
            }

            _userService.Add(term.MapToDto());

            return Created("~terms", term);
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

            return Ok(_userService.Get(filter.MapToDto()).MapToView());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            return Ok(_userService.GetById(id).MapToView());
        }

        [HttpPut]
        public IActionResult Udpate(UserViewModel term)
        {
            if (term == null || term.Id <= 0)
            {
                return BadRequest();
            }

            _userService.Update(term.MapToDto());

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            _userService.Delete(id);

            return NoContent();
        }
    }
}
