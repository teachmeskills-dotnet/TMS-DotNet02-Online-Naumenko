namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class FileTermViewModel
    {
        public int Id { get; set; }

        public int FileId { get; set; }

        public FileViewModel File { get; set; }

        public int TermId { get; set; }

        public TermViewModel Term { get; set; }
    }
}
