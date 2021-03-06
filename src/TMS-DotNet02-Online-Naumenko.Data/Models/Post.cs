using TMS_DotNet02_Online_Naumenko.Data.Models.Enums;

namespace TMS_DotNet02_Online_Naumenko.Data.Models
{
    public class Post
    {
        public int Id { get; set; }

        public int TypeId { get; set; }
        
        public string Title { get; set; }

        public string Slug { get; set; }

        public string Content { get; set; }

        public string Excerpt { get; set; }

        public string ReadingTime { get; set; }

        public DateTime Date { get; set; }

        public DateTime ModificationDate { get; set; }

        public PostStatus PostStatusId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public IEnumerable<PostTerm> PostTerms { get; set; }

        public int FileId { get; set; }

        public File File { get; set; }
    }
}
