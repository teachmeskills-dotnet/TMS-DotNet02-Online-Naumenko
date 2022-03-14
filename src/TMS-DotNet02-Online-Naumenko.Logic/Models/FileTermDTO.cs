namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class FileTermDTO
    {
        public int Id { get; set; }

        public int FileId { get; set; }

        public FileDTO? File { get; set; }

        public int TermId { get; set; }

        public TermDTO? Term { get; set; }
    }
}
