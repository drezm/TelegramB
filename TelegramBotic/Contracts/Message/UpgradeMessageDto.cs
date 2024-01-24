namespace Practice.Contracts.Message
{
    public class UpgradeMessageDto
    {
        public int MessageId { get; set; }
        public int UserId { get; set; }
        public int? EditBy { get; set; }
        public DateTime? EditTime { get; set; }
        public string Contents { get; set; } = null!;
        public int ChatId { get; set; }
    }
}
