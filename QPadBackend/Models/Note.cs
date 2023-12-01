namespace QPadBackend.Models
{
    public class Note
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        //Foreign key
        public required int UserId { get; set; }

        //Navigation Property
        public required User User { get; set; }
    }
}