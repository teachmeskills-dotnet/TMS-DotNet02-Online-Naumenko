using TMS_DotNet02_Online_Naumenko.Data.Repository.Interfaces;
using TMS_DotNet02_Online_Naumenko.Logic.Mappers;
using TMS_DotNet02_Online_Naumenko.Logic.Models;
using TMS_DotNet02_Online_Naumenko.Logic.Services.Interfaces;

namespace TMS_DotNet02_Online_Naumenko.Logic.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        public IEnumerable<UserDto> GetAll(FilterDto filter)
        {
            return _userRepository.GetAll(filter.MapDtoTo()).MapToDto();
        }

        public async Task CreateUser(UserDto user)
        {
            await _userRepository.AddAsync(user.MapDtoTo());
            await _userRepository.SaveChangesAsync();
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
            _userRepository.SaveChangesAsync();
        }

        public async Task UpdateUser(UserDto userDto)
        {
            userDto = userDto ?? throw new ArgumentNullException(nameof(userDto));

            var user = await _userRepository.GetEntityAsync(user => user.Id == userDto.Id);

            user.PasswordHash = userDto.PasswordHash;
            user.Email = userDto.Email;
            user.Name = userDto.Name;
            user.UserRoleId = userDto.UserRoleId;

            await _userRepository.SaveChangesAsync();
        }
    }
}
