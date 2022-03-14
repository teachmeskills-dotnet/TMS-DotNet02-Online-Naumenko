using TMS_DotNet02_Online_Naumenko.Logic.Models;

namespace TMS_DotNet02_Online_Naumenko.Logic.Interfaces
{
    public interface IUserManager
    {
        Task<UserDTO> GetUserByIdAsync();

        Task<IEnumerable<UserDTO>> GetAllUsersAsync();
    }
}
