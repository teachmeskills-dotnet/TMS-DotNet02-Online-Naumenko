namespace TMS_DotNet02_Online_Naumenko.WebApi.ViewModels
{
    public class FilterViewModel
    {
        public string Title { get; set; }

        public int? UserId { get; set; }

        public List<int>? TermIds { get; set; }
    }
}
