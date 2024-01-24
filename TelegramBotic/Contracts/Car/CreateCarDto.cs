namespace Practice.Contracts.Car
{
    public class CreateCarDto
    {
        public int ModelId { get; set; }
        public int CarStatusId { get; set; }
        public int UserId { get; set; }
        public int ManufacturingYear { get; set; }
        public string Mileage { get; set; } = null!;
        public int Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }
    }
}
