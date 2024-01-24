namespace Practice.Contracts.Car
{
    public class UpdateCarDto
    {
        public int CarId { get; set; }
        public int ModelId { get; set; }
        public int CarStatusId { get; set; }
        public int UserId { get; set; }
        public int ManufacturingYear { get; set; }
        public int Mileage { get; set; }
        public int Price { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
        public string? Color { get; set; }

    }
}
