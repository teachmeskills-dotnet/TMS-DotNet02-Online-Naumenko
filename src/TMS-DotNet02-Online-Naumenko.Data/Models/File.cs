namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class File
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public string Name { get; set; }

        public string Slug { get; set; }

        public string Path { get; set; }

        public int FileExtensionId { get; set; }

        public FileExtension FileExtension { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<FileTerm> FileTerms { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
