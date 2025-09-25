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
            var street = new Street("Javier Prado");
            var intersection = new Intersection("Av. Javier Prado x Av. Canadá");

            car.Start();
            street.AddCar(car);
            street.AddTrafficLight(light);
            intersection.AddStreet(street);

            Console.WriteLine($"Car {car.GetLicensePlate()} is on {street.GetName()}");
            Console.WriteLine($"There are {street.GetCarCount()} cars on the street.");
            Console.WriteLine($"Traffic light is {light.GetColor()}");
            Console.WriteLine($"Intersection: {intersection.GetName()} has {intersection.GetStreetCount()} streets.");

            Console.ReadKey();
        }
    }
}