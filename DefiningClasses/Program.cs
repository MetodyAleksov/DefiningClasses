using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Golf";
            car.Model = "MK3";
            car.Year = 1992;
            Console.WriteLine($"{car.Make}");
        }
    }
}
