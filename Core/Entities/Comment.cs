namespace Core.Entities
{
    public class Comment : Base
    {
        public int UserId { get; set; }
        public User? User { get; set; }

        public int NewsID { get; set; }
        public News? News { get; set; }

        public string? Content { get; set; }
    }
}
