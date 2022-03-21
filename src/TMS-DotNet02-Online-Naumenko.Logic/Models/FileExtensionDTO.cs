namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class FileExtensionDto
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public IEnumerable<FileDto>? Files { get; set; }
    }
}
