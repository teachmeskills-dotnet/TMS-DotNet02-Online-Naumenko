using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAll(FilterDto filter);

        Task CreateUser(UserDto user);

        void DeleteUser(int id);

        Task UpdateUser(UserDto userDto);
    }
}
