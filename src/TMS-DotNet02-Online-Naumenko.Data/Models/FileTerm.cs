namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class FileTerm
    {
        public int Id { get; set; }

        public int FileId { get; set; }

        public File File { get; set; }

        public int TermId { get; set; }

        public Term Term { get; set; }
    }
}
