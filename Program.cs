using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


using System;
using System.Threading;

namespace SimulacionTrafico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("🎮 TRAFFIC SIMULATION - JAVIER PRADO AND VIA EVITAMIENTO");
            Console.WriteLine("Choose your car:");
            Console.WriteLine("A) BMW M2 COMPETITION");
            Console.WriteLine("B) SUZUKI ALTO 800");
            Console.WriteLine("C) RIMAC NEVERA");
            Console.WriteLine("D) HONDA CIVIC");

            var carChoice = Console.ReadLine().ToUpper();

            string carModel = "";
            if (carChoice == "A")
            {
                carModel = "BMW M2 COMPETITION";
            }
            else if (carChoice == "B")
            {
                carModel = "SUZUKI ALTO 800";
            }
            else if (carChoice == "C")
            {
                carModel = "RIMAC NEVERA";
            }
            else if (carChoice == "D")
            {
                carModel = "HONDA CIVIC";
            }
            else
            {
                carModel = "UNKNOWN CAR";
            }

            var car = new Car(carModel);

            Console.WriteLine("\nWhat time do you plan to leave for work?");
            Console.WriteLine("A) Night");
            Console.WriteLine("B) Day");

            var timeChoice = Console.ReadLine().ToUpper();

            bool isNight = false;
            if (timeChoice == "A")
            {
                isNight = true;
            }
            else if (timeChoice == "B")
            {
                isNight = false;
            }

            var street = new Street("Javier Prado");
            var intersection = new Intersection("Av. Javier Prado x Av. Canadá");
            var simulator = new TrafficSimulator();

            car.Start();
            street.AddCar(car);
            intersection.AddStreet(street);
            simulator.AddStreet(street);
            simulator.AddIntersection(intersection);

            if (isNight)
            {
                simulator.SetNightMode();
            }

            Console.WriteLine($"\nYou chose: {car.GetModel()}");
            Console.WriteLine($"Time: {(isNight ? "Night" : "Day")}");
            Console.WriteLine("Starting simulation...\n");

            Thread.Sleep(2000);

            // Simulate traffic
            for (int i = 0; i < 10; i++)
            {
                Console.Clear();
                simulator.UpdateTraffic();
                simulator.ShowStats();

                Console.WriteLine($"\nYour car: {car.GetModel()}");
                Console.WriteLine($"Speed: {car.GetSpeed()} km/h");
                Console.WriteLine($"Is moving: {car.IsMoving()}");

                if (isNight && car.GetModel() == "SUZUKI ALTO 800")
                {
                    Console.WriteLine("⚠️ WARNING: Driving at night with an old car!");
                }

                Thread.Sleep(1000);
            }

            // Determine result based on car and time
            var result = DetermineResult(car.GetModel(), isNight);
            Console.WriteLine($"\n🏁 RESULT: {result}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        static string DetermineResult(string carModel, bool isNight)
        {
            if (carModel == "RIMAC NEVERA")
            {
                return "ARRIVED EARLY! Your electric supercar is amazing!";
            }
            else if (carModel == "SUZUKI ALTO 800" && isNight)
            {
                return "ARRIVED LATE! Your old car wasn't suitable for night driving.";
            }
            else if (carModel == "SUZUKI ALTO 800")
            {
                return "ARRIVED ON TIME, but barely!";
            }
            else if (carModel == "BMW M2 COMPETITION")
            {
                if (isNight)
                {
                    return "ARRIVED LATE! Night traffic was too heavy.";
                }
                else
                {
                    return "ARRIVED ON TIME! Sports car performance!";
                }
            }
            else if (carModel == "HONDA CIVIC")
            {
                return "ARRIVED ON TIME! Reliable car choice!";
            }
            else
            {
                return "UNKNOWN OUTCOME!";
            }
        }
    }
}