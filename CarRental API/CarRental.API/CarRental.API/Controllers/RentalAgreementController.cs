using CarRental.API.Models;
using CarRental.API.Services;

using Microsoft.AspNetCore.Mvc;


namespace CarRental.API.Controllers
{
    [ApiController]
    [Route("/api/[Controller]")]
    public class RentalAgreementController : Controller
    {
        private readonly ICarRentalAgreementService _carRentalAgreementService;

        public RentalAgreementController(ICarRentalAgreementService carRentalAgreementService)
        {
            _carRentalAgreementService = carRentalAgreementService;
        }

        // Get all rental agreements
        [HttpGet]
        public async Task<IActionResult> GetAllRentalAgreements()
        {
            var rentalAgreements = await _carRentalAgreementService.GetAllAsync();

            return Ok(rentalAgreements);
        }

        // Create a new car rental agreement.
        [HttpPost]
        public async Task<IActionResult> CreateAgreement([FromBody] CarRentalAgreement carRentalAgreement)
        {
            if (carRentalAgreement == null)
            {
                return BadRequest("Invalid car rental agreement.");
            }

            var createdCarRentalAgreement = await _carRentalAgreementService.CreateAsync(carRentalAgreement);
            
            return Ok(createdCarRentalAgreement);
        }

       

       

            // Retrieve a car rental agreement by its ID.
         [HttpGet("{id}")]
        public async Task<IActionResult> GetAgreementById(int id)
        {
            var carRentalAgreement = await _carRentalAgreementService.GetAsync(id);

            if (carRentalAgreement == null)
            {
                return NotFound();
            }

            return Ok(carRentalAgreement);
        }

        // Update a car rental agreement.
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAgreement(int id, [FromBody] CarRentalAgreement carRentalAgreement)
        {
            if (carRentalAgreement == null)
            {
                return BadRequest("Invalid car rental agreement.");
            }

            var updatedCarRentalAgreement = await _carRentalAgreementService.UpdateAsync(id, carRentalAgreement);

            if (updatedCarRentalAgreement == null)
            {
                return NotFound();
            }

            return Ok(updatedCarRentalAgreement);
        }

        // Delete a car rental agreement.
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgreement(int id)
        {
            await _carRentalAgreementService.DeleteAsync(id);

            return Ok();
        }

    }
}
