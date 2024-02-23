namespace CarRental.API.Data.Entity
{
    public class RentalAgreement
    {
        //Id -> RentalAgreement ID; CarId -> Id of a Car (To be Rented) 
        public int Id { get; set; }
        public int CarId { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarMaker { get; set; }
        public string CustomerName { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentalEndDate { get; set; }
        public decimal RentalPrice { get; set; }
        public bool isRented {get; set; }
    }
}
