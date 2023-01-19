namespace Core.Entities
{
    public class User : Base
    {
        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? Email { get; set; }

        public DateTime Birthday { get; set; }

        public string? Password { get; set; }
    }
}
