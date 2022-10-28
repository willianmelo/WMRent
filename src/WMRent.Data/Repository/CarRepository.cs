using WMRent.Business.Interfaces;
using WMRent.Business.Models;
using WMRent.Data.Context;

namespace WMRent.Data.Repository
{
    public class CarRepository : Repository<Car>, ICarRepository
    {
        public CarRepository(RentDbContext db) : base(db)
        {
        }
    }
}
