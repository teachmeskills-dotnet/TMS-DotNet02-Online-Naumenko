using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using Microsoft.Extensions.Configuration;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class JwtService : IJwtService
    {
        private readonly IConfiguration _iconfiguration;

        public JwtService(IConfiguration iconfiguration)
        {
            _iconfiguration = iconfiguration;
        }

        public TokensDto Generate(UserDto user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.UTF8.GetBytes(_iconfiguration["JWT:Key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.Login),
                    new Claim(ClaimTypes.Role, user.UserRole.Name)
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return new TokensDto { Token = tokenHandler.WriteToken(token) };
        }
    }
}
