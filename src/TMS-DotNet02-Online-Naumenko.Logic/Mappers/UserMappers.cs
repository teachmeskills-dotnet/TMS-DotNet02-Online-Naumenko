using TMS_DotNet02_Online_Naumenko.Data.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Mappers
{
    public static class UserMappers
    {
        public static IEnumerable<UserDto> MapToDto(this IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                yield return new UserDto
                {
                    Id = user.Id,
                    Login = user.Login,
                    PasswordHash = user.PasswordHash,
                    Email = user.Email,
                    Name = user.Name,
                    RegisteredAt = user.RegisteredAt,
                    UserRoleId = user.UserRoleId,
                };
            }
        }

        public static UserDto MapToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Login = user.Login,
                PasswordHash = user.PasswordHash,
                Email = user.Email,
                Name = user.Name,
                RegisteredAt = user.RegisteredAt,
                UserRoleId = user.UserRoleId,
            };
        }

        public static User MapToDomain(this UserDto user)
        {
            return new User
            {
                Id = user.Id,
                Login = user.Login,
                PasswordHash = user.PasswordHash,
                Email = user.Email,
                Name = user.Name,
                RegisteredAt = user.RegisteredAt,
                UserRoleId = user.UserRoleId,
            };
        }
    }
}
