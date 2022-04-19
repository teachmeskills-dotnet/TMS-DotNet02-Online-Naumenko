namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class UserRole
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<User> User { get; set; }
    }
}
