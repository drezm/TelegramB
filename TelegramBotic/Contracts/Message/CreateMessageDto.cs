namespace Practice.Contracts.Message
{
    public class CreateMessageDto
    {
        public int UserId { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedTime { get; set; }
        public string Contents { get; set; } = null!;
        public int ChatId { get; set; }
    }
}
