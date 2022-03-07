using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Mangers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FileController : ControllerBase
    {
        private readonly IFileManager _fileManager;

        public FileController(IFileManager fileManager)
        {
            _fileManager = fileManager ?? throw new ArgumentNullException(nameof(fileManager));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _fileManager.GetAllFilesAsync();

            return Ok(result);
        }
    }
}
