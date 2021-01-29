using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            car.Make = "Ferrari";
            car.Model = "Mk3";
            car.Year = 2003;
            car.FuelQuantity = 100;
            car.FuelConsumption = 100;

            car.Drive(0.2);
            car.WhoAmI();
        }
    }

}
