using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WMRent.Business.Models;

namespace WMRent.Data.Mappings
{
    public class CarMapping : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(p => p.Automaker)
                .IsRequired()
                .HasColumnType("varchar(100)");


            builder.Property(p => p.Color)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(p => p.NumberOfPlaces)
                .IsRequired()
                .HasColumnType("integer(7)");

            builder.Property(p => p.YearOfManufacture)
                .IsRequired()
                .HasColumnType("integer(2)");

            builder.Property(p => p.Renavam)
               .IsRequired()
               .HasColumnType("varchar(11)");
        }
    }
}
