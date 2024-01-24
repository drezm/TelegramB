namespace Practice.Contracts.CarStatus
{
    public class UpdateCarStatusDto
    {
        public int CarStatusId { get; set; }
        public string StatusName { get; set; } = null!;
    }
}
