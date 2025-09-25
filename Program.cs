using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTrafico
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("ABC123");
            car.Start();
            Console.WriteLine($"Car {car.GetLicensePlate()} is moving at {car.GetSpeed()} km/h");
            car.Stop();
            Console.WriteLine($"Car {car.GetLicensePlate()} stopped.");
            Console.ReadKey();
        }
    }
}
