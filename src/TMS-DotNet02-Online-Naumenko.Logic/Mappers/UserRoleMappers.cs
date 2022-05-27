using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class UserRoleMappers
    {
        public static IEnumerable<UserRoleDto> MapToDto(this IEnumerable<UserRole> roles)
        {
            foreach (var role in roles)
            {
                yield return new UserRoleDto
                {
                    Id = role.Id,
                    Name = role.Name,
                };
            }
        }

        public static UserRoleDto MapToDto(this UserRole role)
        {
            return new UserRoleDto
            {
                Id = role.Id,
                Name = role.Name,
            };
        }

        public static UserRole MapToDomain(this UserRoleDto role)
        {
            return new UserRole
            {
                Id = role.Id,
                Name = role.Name,
            };
        }
    }
}
