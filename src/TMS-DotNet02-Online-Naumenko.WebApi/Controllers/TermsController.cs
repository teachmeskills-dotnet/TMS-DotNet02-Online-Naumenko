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
    public class TermsController : ControllerBase
    {
        private readonly ITermService _termService;

        public TermsController(ITermService termService)
        {
            _termService = termService ?? throw new ArgumentNullException(nameof(termService));
        }

        [HttpPost]
        public IActionResult Create(TermViewModel term)
        {
            if (term == null || term.Id <= 0)
            {
                return BadRequest();
            }

            _termService.Add(term.MapToDto());

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

            return Ok(_termService.Get(filter.MapToDto()).MapToView());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            return Ok(_termService.GetById(id).MapToView());
        }

        [HttpPut]
        public IActionResult Udpate(TermViewModel term)
        {
            if (term == null || term.Id <= 0)
            {
                return BadRequest();
            }

            _termService.Update(term.MapToDto());

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            _termService.Delete(id);

            return NoContent();
        }
    }
}
