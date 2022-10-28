using WMRent.Business.Models;

namespace WMRent.Business.Interfaces
{
    public interface ICarService : IDisposable
    {
        Task Add(Car car);
    }
}
