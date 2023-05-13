using BlogsApi.Entities;

namespace BlogsApi.Model
{
    public class BlogModel
    {
        //
        public string? Id { get; set; }

        public string? Title { get; set; }

        public string? Body { get; set; }

        public DateTime? CreateDate { get; set; }

        public DateTime? UpdateDate { get; set; }

        public DateTime? DeleteDate { get; set; }

        public int CreatorId { get; set; }
    }
}
