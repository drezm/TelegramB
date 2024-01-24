namespace Practice.Contracts.Advertisement
{
    public class UpdateAdvertisementDto
    {
        public int AdId { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public int AdStatusId { get; set; }
        public string Title { get; set; } = null!;
        public string? Discription { get; set; }
        public int? EditBy { get; set; }
        public DateTime? EditTime { get; set; }
    }
}
