namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Login { get; set; }

        public string PasswordHash { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public DateTime RegisteredAt { get; set; }

        public IEnumerable<PostDto> Posts { get; set; }

        public IEnumerable<TermDto> Terms { get; set; }

        public IEnumerable<FileDto> Files { get; set; }

        public int UserRoleId { get; set; }

        public UserRoleDto UserRole { get; set; }
    }
}
