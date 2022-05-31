namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class UserRoleDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<UserDto> User { get; set; }
    }
}
