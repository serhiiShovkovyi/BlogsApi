namespace BlogsApi.Entities
{
    public class Blog
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public string? Body { get; set; }

        public DateTime PostDate { get; set; }

        public DateTime UpdateDate { get; set; }

        public bool IsDeleted { get; set; }

        public int CreatorId { get; set; }
    }
}
