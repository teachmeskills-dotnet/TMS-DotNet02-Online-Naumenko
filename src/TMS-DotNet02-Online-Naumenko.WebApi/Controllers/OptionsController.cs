using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OptionsController : ControllerBase
    {
        private readonly IOptionService _optionService;

        public OptionsController(IOptionService optionService)
        {
            _optionService = optionService ?? throw new ArgumentNullException(nameof(optionService));
        }

        [HttpGet]
        public IEnumerable<OptionDto> GetAll()
        {
            FilterDto filter = new FilterDto
            {
            };
            
            return _optionService.GetAll(filter);
        }
    }
}
