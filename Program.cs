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
            var simulator = new TrafficSimulator();

            car.Start();
            street.AddCar(car);
            street.AddTrafficLight(light);
            intersection.AddStreet(street);
            simulator.AddStreet(street);
            simulator.AddIntersection(intersection);

            simulator.StartSimulation();

            Console.ReadKey();
        }
    }
}