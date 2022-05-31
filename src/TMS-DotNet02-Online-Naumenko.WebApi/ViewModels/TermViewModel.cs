using TMS_DotNet02_Online_Naumenko.Data.Models.Enums;

namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class TermViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public int Parent { get; set; }

        public int UserId { get; set; }

        public UserViewModel User { get; set; }

        public TermType TermTypeId { get; set; }

        public IEnumerable<PostTermViewModel> PostTerms { get; set; }

        public IEnumerable<FileTermViewModel> FileTerms { get; set; }
    }
}
