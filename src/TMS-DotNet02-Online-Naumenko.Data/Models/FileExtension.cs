namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class FileExtension
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<File> Files { get; set; }
    }
}