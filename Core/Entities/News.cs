namespace Core.Entities
{
    public class News : Base
    {
        public string? Title { get; set; }

        public string? Description { get; set; }

        public int LanguageId { get; set; }
        public Language?  Language { get; set; }

        public int ImageId { get; set; }
        public Image? Image { get; set; }
    }
}
