namespace Rentocam.Domain
{
    public class CameraDetails
    {
        public Guid Id { get; set; } 
        public string ModelName { get; set; }
        public string Manufacturer { get; set; }  
        public string? Weight { get ; set; }
        public int YearOfManufacture { get; set; }
        public string? Color { get; set; }

    }
}