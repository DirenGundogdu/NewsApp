namespace Core.Entities
{
    public class NewsTag
    {
        public Guid Id { get; set; }

        public int NewsId { get; set; }
        public News?  News { get; set; }

        public int TagId { get; set; }
        public Tag? Tag { get; set; }
    }
}
