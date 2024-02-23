using CarRental.API.Models;
using CarRental.API.Repositories;

namespace CarRental.API.Services
{
    public class CarRentalAgreementService : ICarRentalAgreementService
    {
        private readonly ICarRentalAgreementRepository _carRentalAgreementRepository;

        public CarRentalAgreementService(ICarRentalAgreementRepository carRentalAgreementRepository)
        {
            _carRentalAgreementRepository = carRentalAgreementRepository;
        }
        //Get all rental agreements
        public async Task<IEnumerable<CarRentalAgreement>> GetAllAsync()
        {
            return await _carRentalAgreementRepository.GetAllAsync();
        }
        public async Task<CarRentalAgreement> CreateAsync(CarRentalAgreement carRentalAgreement)
        {
            return await _carRentalAgreementRepository.CreateAsync(carRentalAgreement);
        }

        public async Task<CarRentalAgreement> GetAsync(int id)
        {
            return await _carRentalAgreementRepository.GetAsync(id);
        }

        public async Task<CarRentalAgreement> UpdateAsync(int id, CarRentalAgreement carRentalAgreement)
        {
            return await _carRentalAgreementRepository.UpdateAsync(id, carRentalAgreement);
        }

        public async Task DeleteAsync(int id)
        {
            await _carRentalAgreementRepository.DeleteAsync(id);
        }
    }
}
