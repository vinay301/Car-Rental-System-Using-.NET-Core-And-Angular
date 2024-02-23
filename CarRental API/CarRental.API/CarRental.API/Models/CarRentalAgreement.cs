namespace CarRental.API.Models
{
    public class CarRentalAgreement
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarModel{ get; set; }
        public string CarMaker { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public decimal RentalPrice { get; set; }

        public bool isRented { get; set; }
    }
}
