namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 1992;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelConsumption = fuelConsumption;
            FuelQuantity = fuelQuantity;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
    }
}
