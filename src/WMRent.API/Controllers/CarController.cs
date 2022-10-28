using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WMRent.Business.Interfaces;
using WMRent.Business.Models;

namespace WMRent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : MainController
    {
        private readonly IValidator<Car> _validator;
        private readonly ICarService _carService;

        public CarController(IValidator<Car> validator,
                             ICarService carService,
                             INotifier notifier) : base(notifier)
        {
            _validator = validator;
            _carService = carService;
        }

        [HttpPost("Insert")]
        public async Task<ActionResult<Car>> Adicionar(Car car)
        {
            var validation = await _validator.ValidateAsync(car);

            if (!validation.IsValid)
                return CustomResponse(validation);

            await _carService.Add(car);

            return CustomResponse(car);
        }


        [HttpGet("GetAll")]
        public async Task<IEnumerable<Car>> GetAll()
        {
            return new List<Car>
            {
                new Car { Automaker = "Chevrolet", Color ="Blue", NumberOfPlaces = 7, YearOfManufacture = 2020, Value = 2000}
            };
        }

    }
}