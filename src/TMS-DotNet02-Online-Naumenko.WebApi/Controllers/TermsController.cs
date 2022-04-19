using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

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

        [HttpGet]
        public IEnumerable<TermDto> GetAll()
        {
            FilterDto filter = new FilterDto
            {
                UserId = 2,
            };

            return _termService.GetAll(filter);
        }
    }
}
