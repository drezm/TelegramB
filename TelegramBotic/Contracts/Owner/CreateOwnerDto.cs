namespace Practice.Contracts.Owner
{
    public class CreateOwnerDto
    {
        public DateTime? TenurePeriodFrom { get; set; }
        public DateTime? TenurePeriodTo { get; set; }
        public int CarId { get; set; }
    }
}
