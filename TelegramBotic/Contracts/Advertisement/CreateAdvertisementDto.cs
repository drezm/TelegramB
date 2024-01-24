namespace Practice.Contracts.Advertisement
{
    public class CreateAdvertisementDto
    {
        public int UserId { get; set; }
        public int CarId { get; set; }
        public int AdStatusId { get; set; }
        public string Title { get; set; } = null!;
        public string? Discription { get; set; }
        public int? AddedBy { get; set; }
        public DateTime? AddedTime { get; set; }
    }
}
