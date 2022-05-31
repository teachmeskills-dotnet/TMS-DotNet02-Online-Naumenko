namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class PostTermViewModel
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public PostViewModel Post { get; set; }

        public int TermId { get; set; }

        public TermViewModel Term { get; set; }
    }
}
