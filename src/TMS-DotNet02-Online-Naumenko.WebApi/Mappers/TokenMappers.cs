using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class TokenMappers
    {
        public static TokensViewModel MapToView(this TokensDto token)
        {
            return new TokensViewModel
            {
                Token = token.Token
            };
        }

        public static TokensDto MapToDto(this TokensViewModel token)
        {
            return new TokensDto
            {
                Token = token.Token
            };
        }
    }
}
