namespace Practice.Contracts.Owner
{
    public class UpdateOwnerDto
    {
        public int OwnnerId { get; set; }
        public DateTime? TenurePeriodFrom { get; set; }
        public DateTime? TenurePeriodTo { get; set; }
        public int CarId { get; set; }
    }
}
