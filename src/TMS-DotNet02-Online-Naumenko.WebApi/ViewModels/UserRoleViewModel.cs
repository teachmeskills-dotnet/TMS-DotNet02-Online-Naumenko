namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class UserRoleViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<UserViewModel>? User { get; set; }
    }
}
