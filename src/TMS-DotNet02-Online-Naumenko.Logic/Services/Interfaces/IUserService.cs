using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces
{
    public interface IUserService
    {
        Task Add(UserDto userDto);

        IEnumerable<UserDto> Get(FilterDto filterDto);

        UserDto GetById(int id);

        Task Update(UserDto userDto);

        void Delete(int id);
    }
}
