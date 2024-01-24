namespace Practice.Contracts.Owner
{
    public class GetOwnerDto
    {
        public int OwnnerId { get; set; }
        public DateTime? TenurePeriodFrom { get; set; }
        public DateTime? TenurePeriodTo { get; set; }
    }
}
