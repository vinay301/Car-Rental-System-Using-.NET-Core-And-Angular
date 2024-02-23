using CarRental.API.Data;
using CarRental.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Repositories
{
    public class CarRentalAgreementRepository : ICarRentalAgreementRepository
    {
        private readonly CarRentalDbContext _carRentalDbContext;
       
        public CarRentalAgreementRepository(CarRentalDbContext carRentalDbContext) 
        {
            this._carRentalDbContext = carRentalDbContext;
            //inject DbContext
            
        }
        // Get all rental agreements
        public async Task<IEnumerable<CarRentalAgreement>> GetAllAsync()
        {
            return await _carRentalDbContext.CarRentalAgreements.ToListAsync();
        }

        public async Task<CarRentalAgreement> CreateAsync(CarRentalAgreement carRentalAgreement)
        {
            _carRentalDbContext.CarRentalAgreements.Add(carRentalAgreement);
            await _carRentalDbContext.SaveChangesAsync();

            return carRentalAgreement;
        }

        public async Task<CarRentalAgreement> GetAsync(int id)
        {
            return await _carRentalDbContext.CarRentalAgreements.FindAsync(id);
        }

        public async Task<CarRentalAgreement> UpdateAsync(int id, CarRentalAgreement carRentalAgreement)
        {
            _carRentalDbContext.CarRentalAgreements.Update(carRentalAgreement);
            await _carRentalDbContext.SaveChangesAsync();

            return carRentalAgreement;
        }

        public async Task DeleteAsync(int id)
        {
            var carRentalAgreement = await _carRentalDbContext.CarRentalAgreements.FindAsync(id);
            _carRentalDbContext.CarRentalAgreements.Remove(carRentalAgreement);
            await _carRentalDbContext.SaveChangesAsync();
        }
    }
}
