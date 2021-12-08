namespace RentACar.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public double PricePerDay { get; set; }
        public string Photo { get; set; }
    }
}
