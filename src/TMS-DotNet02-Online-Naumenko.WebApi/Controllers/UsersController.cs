using Microsoft.AspNetCore.Authorization;
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
        private readonly IJwtService _jwtService;

        public UsersController(IUserService userService, IJwtService jwtService)
        {
            _userService = userService ?? throw new ArgumentNullException(nameof(userService));
            _jwtService = jwtService ?? throw new ArgumentNullException(nameof(jwtService));
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Add(UserViewModel user)
        {
            if (user == null)
            {
                return BadRequest();
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);

            await _userService.Add(user.MapToDto());

            return Created("~users", user);
        }

        [HttpGet]
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> GetById(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            return Ok((await _userService.GetById(id)).MapToView());
        }

        [HttpPut] 
        [Authorize]
        public async Task<IActionResult> Udpate(UserViewModel user)
        {
            if (user == null || user.Id <= 0)
            {
                return BadRequest();
            }

            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);

            await _userService.Update(user.MapToDto());

            return Ok();
        }

        [HttpDelete]
        [Authorize(Roles = "admin")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }

            _userService.Delete(id);

            return NoContent();
        }

        [HttpPost(template: "login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel login)
        {
            UserViewModel user = (await _userService.GetByLogin(login.Login)).MapToView();

            if (user == null)
            {
                return BadRequest(error: new {message = "User don't exist"});
            }
            else if(!BCrypt.Net.BCrypt.Verify(login.Password, user.PasswordHash))
            {
                return BadRequest(error: new {message = "Invalid Password"});
            }
            else
            {
                TokensViewModel token = _jwtService.Generate(user.MapToDto()).MapToView();
                
                if (token == null)
                {
                    return Unauthorized();
                }

                AuthenticationViewModel authentication = new (){
                    Id = user.Id,
                    Login = user.Login,
                    Role = user.UserRole.Name,
                    Name = user.Name,
                    Token = token.Token
                };

                Response.Cookies.Append(key: "token", value: authentication.Token, new CookieOptions
                {
                    HttpOnly = true
                });

                return Ok(authentication);
            }

            return Unauthorized();
        }

        [HttpGet(template: "verify")]
        public IActionResult Verify()
        {
            try
            {
                var jwt = Request.Cookies["token"];
                var token = _jwtService.Verify(jwt);
                List<object> logins = token.Payload.Values.ToList();
                //var userId = token.Issuer;
                var user = _userService.GetByLogin(logins[0].ToString());

                return Ok(user);
            }   
            catch (Exception )
            {
                return Unauthorized();
            }
        }

        [HttpPost(template: "logout")]
        [Authorize]
        public IActionResult Logout()
        {
            Response.Cookies.Delete(key: "token");

            return Ok();
        }
    }
}
