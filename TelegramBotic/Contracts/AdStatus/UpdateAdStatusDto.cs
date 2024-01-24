namespace Practice.Contracts.AdStatus
{
    public class UpdateAdStatusDto
    {
        public int AdStatusId { get; set; }
        public string StatusName { get; set; } = null!;
    }
}
