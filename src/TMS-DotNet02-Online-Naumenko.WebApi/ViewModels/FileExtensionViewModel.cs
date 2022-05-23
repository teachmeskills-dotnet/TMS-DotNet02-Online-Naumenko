namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class FileExtensionViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<FileViewModel> Files { get; set; }
    }
}
