namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class UserRoleDTO
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public IEnumerable<UserDto>? User { get; set; }
    }
}
