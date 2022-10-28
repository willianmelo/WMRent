using Microsoft.EntityFrameworkCore;
using WMRent.Business.Models;

namespace WMRent.Data.Context
{
    public class RentDbContext : DbContext
    {
        public RentDbContext(DbContextOptions<RentDbContext> opt) : base(opt)
        {

        }

        public DbSet<Car> Cars { get; set; }
    }
}
