using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();

            string[] curr = Console.ReadLine()
                .Split();

            while (curr[0] != "No" && curr[1] != "more" && curr[2] != "tires")
            {
                Tire[] currTires = new Tire[4] {
                    new Tire(int.Parse(curr[0]), double.Parse(curr[1])),
                    new Tire(int.Parse(curr[2]), double.Parse(curr[3])),
                    new Tire(int.Parse(curr[4]), double.Parse(curr[5])),
                    new Tire(int.Parse(curr[6]), double.Parse(curr[7]))
                };

                tires.Add(currTires);

                curr = Console.ReadLine()
                .Split();
            }

            curr = Console.ReadLine()
                .Split();

            List<Engine> engines = new List<Engine>();

            while (curr[0] != "Engines" && curr[1] != "dones")
            {
                Engine currEngine = new Engine(int.Parse(curr[0]), double.Parse(curr[1]));

                engines.Add(currEngine);

                curr = Console.ReadLine()
                .Split();
            }

            curr = Console.ReadLine()
                .Split();

            List<Car> cars = new List<Car>();

            while (curr[0] != "Show" && curr[1] != "special")
            {
                Car currCar = new Car(curr[0], 
                    curr[1], 
                    int.Parse(curr[2]), 
                    double.Parse(curr[3]),
                    double.Parse(curr[4]), 
                    engines[int.Parse(curr[5])],
                    tires[int.Parse(curr[6])]);

                cars.Add(currCar);

                curr = Console.ReadLine()
                .Split();
            }

            for (int i = 0; i < cars.Count; i++)
            {
                for (int j = 0; j < cars[i].Tires.Length; j++)
                {
                    if (cars[i].Tires[j].Pressure >= 9.0 && cars[i].Tires[j].Pressure <= 10.0)
                    {
                        cars.RemoveAt(i);
                        i--;
                        break;
                    }
                }
            }

            foreach (var car in cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.FuelQuantity > 0))
            {
                double leftFuel = car.FuelQuantity - (car.FuelConsumption * 2.0);
                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {leftFuel}");
            }
        }
    }
}
