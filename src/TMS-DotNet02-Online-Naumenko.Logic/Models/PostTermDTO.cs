namespace TMS_DotNet02_Online_Naumenko.Logic.Models
{
    public class PostTermDTO
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public PostDto? Post { get; set; }

        public int TermId { get; set; }

        public TermDto? Term { get; set; }
    }
}
