using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.WebApi.ViewModels;

namespace TMS_DotNet02_Online_Naumenko.WebApi.Mappers
{
    public static class UserMappers
    {
        public static UserDto MapToDto(this UserViewModel user)
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

        public static IEnumerable<UserViewModel> MapToView(this IEnumerable<UserDto> users)
        {
            foreach (var user in users)
            {
                yield return new UserViewModel
                {
                    Id = user.Id,
                    Login = user.Login,
                    PasswordHash = user.PasswordHash,
                    Email = user.Email,
                    Name = user.Name,
                    RegisteredAt = user.RegisteredAt,
                    UserRoleId = user.UserRoleId,
                    UserRole = user.UserRole.MapToView()
                };
            }
        }

        public static UserViewModel MapToView(this UserDto user)
        {
            return new UserViewModel
            {
                Id = user.Id,
                Login = user.Login,
                PasswordHash = user.PasswordHash,
                Email = user.Email,
                Name = user.Name,
                RegisteredAt = user.RegisteredAt,
                UserRoleId= user.UserRoleId,
                UserRole = user.UserRole.MapToView()
            };
        }
    }
}
