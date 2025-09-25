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
            var light = new TrafficLight();

            car.Start();
            Console.WriteLine($"Car {car.GetLicensePlate()} is moving at {car.GetSpeed()} km/h");

            Console.WriteLine($"Traffic light is {light.GetColor()}");
            light.ChangeColor();
            Console.WriteLine($"Traffic light changed to {light.GetColor()}");

            car.Stop();
            Console.WriteLine($"Car {car.GetLicensePlate()} stopped.");

            Console.ReadKey();
        }
    }
}