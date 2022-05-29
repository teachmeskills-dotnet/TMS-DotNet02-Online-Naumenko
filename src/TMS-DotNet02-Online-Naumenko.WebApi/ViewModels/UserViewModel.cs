using System.Text.Json.Serialization;

namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string Login { get; set; }

        [JsonIgnore] public string PasswordHash { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public DateTime RegisteredAt { get; set; }

        public IEnumerable<PostViewModel>? Posts { get; set; }

        public IEnumerable<TermViewModel>? Terms { get; set; }

        public IEnumerable<FileViewModel>? Files { get; set; }

        public int UserRoleId { get; set; }

        public UserRoleViewModel? UserRole { get; set; }
    }
}
