using CarRental.API.Models;

namespace CarRental.API.Services
{
    public interface ICarRentalAgreementService
    {
        
        // Get all rental agreements
        Task<IEnumerable<CarRentalAgreement>> GetAllAsync();
        Task<CarRentalAgreement> CreateAsync(CarRentalAgreement carRentalAgreement);
        Task<CarRentalAgreement> GetAsync(int id);
        Task<CarRentalAgreement> UpdateAsync(int id, CarRentalAgreement carRentalAgreement);
        Task DeleteAsync(int id);
    }
}
