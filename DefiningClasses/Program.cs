using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("VW", "Mk3", 1992);
            Console.WriteLine(car.ToString());
        }
    }

}
