namespace WMRent.Business.Models
{
    public class Car : Entity
    {
        public string Automaker { get; set; }

        public int NumberOfPlaces { get; set; }

        public string Color { get; set; }

        public int YearOfManufacture { get; set; }

        public decimal Value { get; set; }

        public string Renavam { get; set; }
    }
}
