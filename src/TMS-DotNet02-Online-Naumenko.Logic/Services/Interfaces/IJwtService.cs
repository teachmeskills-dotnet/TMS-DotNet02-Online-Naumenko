using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IJwtService
    {
        TokensDto Generate(UserDto user);

        JwtSecurityToken Verify(string jwt);
    }
}
