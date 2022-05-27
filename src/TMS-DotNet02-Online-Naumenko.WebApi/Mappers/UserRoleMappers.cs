using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class UserRoleMappers
    {
        public static IEnumerable<UserRoleViewModel> MapToView(this IEnumerable<UserRoleDto> roles)
        {
            foreach (var role in roles)
            {
                yield return new UserRoleViewModel
                {
                    Id = role.Id,
                    Name = role.Name,
                };
            }
        }

        public static UserRoleViewModel MapToView(this UserRoleDto role)
        {
            return new UserRoleViewModel
            {
                Id = role.Id,
                Name = role.Name,
            };
        }

        public static UserRoleDto MapToDto(this UserRoleViewModel role)
        {
            return new UserRoleDto
            {
                Id = role.Id,
                Name = role.Name,
            };
        }
    }
}
