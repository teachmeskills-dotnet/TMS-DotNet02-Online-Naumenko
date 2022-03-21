namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class FileTermDto
    {
        public int Id { get; set; }

        public int FileId { get; set; }

        public FileDto? File { get; set; }

        public int TermId { get; set; }

        public TermDto? Term { get; set; }
    }
}
