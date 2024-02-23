namespace CarRental.API.Models
{
    public class CarViewModel
    {
       
        public Guid Id { get; set; }
        public String Name { get; set; }
        public String Maker { get; set; }
        public String Model { get; set; }
        public int PricePerDay { get; set; }
        public string CarImageUrl { get; set; }
        public Boolean IsAvailable { get; set; } = false;
    }
}
