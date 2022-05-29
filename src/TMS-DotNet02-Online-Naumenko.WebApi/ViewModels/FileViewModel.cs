namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class FileViewModel
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Link { get; set; }

        public int FileExtensionId { get; set; }

        public FileExtensionViewModel? FileExtension { get; set; }

        public int UserId { get; set; }

        public UserViewModel? User { get; set; }

        public IEnumerable<FileTermViewModel>? FileTerms { get; set; }

        public IEnumerable<PostViewModel>? Posts { get; set; }
    }
}
