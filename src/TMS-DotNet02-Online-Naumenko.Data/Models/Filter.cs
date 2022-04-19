namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class Filter
    {
        public string Title { get; set; }

        public int UserId { get; set; }

        public List<int> TermIds { get; set; }
    }
}
