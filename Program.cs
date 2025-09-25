using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace SimulacionTrafico
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("ABC123");
            var light = new TrafficLight();
            var street = new Street("Javier Prado");

            car.Start();
            street.AddCar(car);
            street.AddTrafficLight(light);

            Console.WriteLine($"Car {car.GetLicensePlate()} is on {street.GetName()}");
            Console.WriteLine($"There are {street.GetCarCount()} cars on the street.");
            Console.WriteLine($"Traffic light is {light.GetColor()}");

            Console.ReadKey();
        }
    }
}