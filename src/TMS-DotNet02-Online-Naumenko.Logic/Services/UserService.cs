using System.Linq.Expressions;
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

        public async Task Add(UserDto userDto)
        {
            await _userRepository.AddAsync(userDto.MapToDomain());
            await _userRepository.SaveChangesAsync();
        }

        public IEnumerable<UserDto> Get(FilterDto filterDto)
        {
            return _userRepository.Get(filterDto.MapToDomain()).MapToDto();
        }

        public async Task<UserDto> GetById(int id)
        {
            return (await _userRepository.GetByIdAsync(user => user.Id == id)).MapToDto();
        }

        public async Task<UserDto> GetByLogin(string login)
        {
            return (await _userRepository.GetByIdAsync(user => user.Login == login)).MapToDto();
        }

        public async Task Update(UserDto userDto)
        {
            userDto = userDto ?? throw new ArgumentNullException(nameof(userDto));

            var user = await _userRepository.GetByIdAsync(user => user.Id == userDto.Id);

            user.PasswordHash = userDto.PasswordHash;
            user.Email = userDto.Email;
            user.Name = userDto.Name;
            user.UserRoleId = userDto.UserRoleId;

            await _userRepository.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            _userRepository.Delete(id);
            _userRepository.SaveChangesAsync();
        }
    }
}
