using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

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

        [HttpGet]
        public IEnumerable<UserDto> GetAll()
        {
            FilterDto filter = new FilterDto
            {
                UserId = 2,
            };

            return _userService.GetAll(filter);
        }

        [HttpPost]
        public IEnumerable<UserDto> Auth()
        {
            FilterDto filter = new FilterDto
            {
                UserId = 2,
            };

            return _userService.GetAll(filter);
        }
    }
}
