using WMRent.Business.Interfaces;
using WMRent.Business.Models;

namespace WMRent.Business.Services
{
    public class CarService : BaseService, ICarService
    {
        private readonly ICarRepository _carRepository;

        public CarService(ICarRepository carRepository,
                          INotifier notifier) : base(notifier)
        {
            _carRepository = carRepository;
        }

        public async Task Add(Car car)
        {
            if (_carRepository.Search(c => c.Renavam == car.Renavam).Result.Any())
            {
                Notifier($"Already exist a car with this Renavam {car.Renavam}.");
                return;
            }

            await _carRepository.Add(car);
        }

        public void Dispose()
        {
            _carRepository?.Dispose();
        }
    }
}
