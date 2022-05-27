using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IUserService
    {
        Task Add(UserDto userDto);

        IEnumerable<UserDto> Get(FilterDto filterDto);

        Task<UserDto> GetById(int id);

        Task<UserDto> GetByLogin(string login);

        Task Update(UserDto userDto);

        void Delete(int id);
    }
}
