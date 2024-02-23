using CarRental.API.Data;
using CarRental.API.Data.Entity;
using CarRental.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarRental.API.Controllers
{
    //to tell the dotnet that it won't have any views and its an API controller
    [ApiController]
    //place name of the controller
    [Route("/api/Car")]
    public class CarController : Controller
    {
        //variable
        private readonly CarRentalDbContext _carRentalDbContext;

        public CarController(CarRentalDbContext carRentalDbContext)
        {
            this._carRentalDbContext = carRentalDbContext;
            //inject DbContext
        }

        //To get all the Cars List
        [HttpGet]
        [Route("Cars")] //custom Route
        public async Task <IActionResult> GetAllCarsList()
        {
            var cars = await _carRentalDbContext.Cars.ToListAsync();
            //it has the status 200 for proper working
            return Ok(cars);
        }

        [HttpPost]
        [Route("AddCars")] //custom Route

        //API Call for ADD PRODUCTS
        public async Task<IActionResult> AddCar([FromBody] CarViewModel carAddRequest)
        {
            //carAddRequest.Id = Guid.NewGuid();
            Cars car = new()
            {
                Id = Guid.NewGuid(),
                Name = carAddRequest.Name,
                Maker = carAddRequest.Maker,
                Model = carAddRequest.Model,
                PricePerDay = carAddRequest.PricePerDay,
                CarImageUrl = carAddRequest.CarImageUrl,
                IsAvailable = carAddRequest.IsAvailable
            };
            
            await _carRentalDbContext.Cars.AddAsync(car);
            await _carRentalDbContext.SaveChangesAsync();
            return Ok(car);
        }

        //Method to call API, to view product when id is matched
        [HttpGet]
        [Route("{id:Guid}")] //custom Route

        public async Task<IActionResult> GetCarById([FromRoute] Guid id)
        {
            var product = await _carRentalDbContext.Cars.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //API Call for Edit Product
        //HttpPut -> Update
        [HttpPut]
        [Route("{id:Guid}")] //custom Route

        public async Task<IActionResult> EditCar([FromRoute] Guid id, Cars editCarRequest)
        {
            var car = await _carRentalDbContext.Cars.FindAsync(id);
            //if id is null return not found request
            if (car == null)
            {
                return NotFound();
            }

            //if id is present, update the data except id
            car.Name = editCarRequest.Name;
            car.Maker = editCarRequest.Maker;
            car.Model = editCarRequest.Model;
            car.PricePerDay = editCarRequest.PricePerDay;
            car.CarImageUrl = editCarRequest.CarImageUrl;
            car.IsAvailable = editCarRequest.IsAvailable;

            //after update, save the changes
            await _carRentalDbContext.SaveChangesAsync();

            //after save, return OK response with updated car
            return Ok(car);
        }

        //API CALL TO DELETE CAR
        [HttpDelete]
        [Route("{id:Guid}")] //custom Route
        public async Task<IActionResult> DeleteCar([FromRoute] Guid id)
        {
            var car = await _carRentalDbContext.Cars.FindAsync(id);
            //if id is null, return not found
            if (car == null)
            {
                return NotFound();
            }
            //if id is present remove it
            _carRentalDbContext.Cars.Remove(car);
            //save it
            await _carRentalDbContext.SaveChangesAsync();
            //return with Ok response
            return Ok(car);
        }
    }
}
