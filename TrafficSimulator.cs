using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionTrafico
{
    public class TrafficSimulator
    {
        private List<Street> _streets;
        private List<Intersection> _intersections;
        private int _currentHour;
        private bool _isWeekend;
        private bool _isNight;

        public TrafficSimulator()
        {
            _streets = new List<Street>();
            _intersections = new List<Intersection>();
            _currentHour = 8; // 8 AM
            _isWeekend = false;
            _isNight = false;
        }

        public void AddStreet(Street street)
        {
            _streets.Add(street);
        }

        public void AddIntersection(Intersection intersection)
        {
            _intersections.Add(intersection);
        }

        public void StartSimulation()
        {
            Console.WriteLine("Traffic simulation started!");
            UpdateTraffic();
            ShowStats();
        }

        public void UpdateTraffic()
        {
            _currentHour++;
            if (_currentHour > 23) _currentHour = 0;

            if (_currentHour >= 18 || _currentHour < 6)
            {
                _isNight = true;
            }
            else
            {
                _isNight = false;
            }

            if (_currentHour >= 7 && _currentHour <= 9 || _currentHour >= 17 && _currentHour <= 19)
            {
                Console.WriteLine("⚠️ Traffic jam alert: Peak hours detected!");
            }
        }

        public void ShowStats()
        {
            Console.WriteLine($"Current hour: {_currentHour}:00");
            Console.WriteLine($"Is weekend: {_isWeekend}");
            Console.WriteLine($"Is night: {_isNight}");
            Console.WriteLine($"Total streets: {_streets.Count}");
            Console.WriteLine($"Total intersections: {_intersections.Count}");
        }

        public void SetNightMode()
        {
            _isNight = true;
        }

        public bool IsPeakHour()
        {
            return (_currentHour >= 7 && _currentHour <= 9) || (_currentHour >= 17 && _currentHour <= 19);
        }

        public bool IsWeekendNight()
        {
            return _isWeekend && (_currentHour >= 18 || _currentHour < 6);
        }

        public void SimulateTrafficEvent()
        {
            var random = new Random();
            var eventNumber = random.Next(1, 100);

            if (eventNumber <= 30) // 30% de probabilidad de semáforo
            {
                SimulateTrafficLightEvent();
            }
            else if (eventNumber <= 40) // 10% de probabilidad de policía
            {
                SimulatePoliceEvent();
            }
        }

        private void SimulateTrafficLightEvent()
        {
            var random = new Random();
            var lightColor = random.Next(1, 3);

            if (lightColor == 1)
            {
                Console.WriteLine("🔴 RED LIGHT! Cross?");
                Console.WriteLine("A) Yes");
                Console.WriteLine("B) No");

                var choice = Console.ReadLine().ToUpper();

                if (choice == "A")
                {
                    Console.WriteLine("⚠️ You crossed on red! Risky move!");
                }
                else
                {
                    Console.WriteLine("✅ Good! You waited for green light.");
                }
            }
            else
            {
                Console.WriteLine("🟢 GREEN LIGHT! Keep going.");
            }
        }

        private void SimulatePoliceEvent()
        {
            Console.WriteLine("🚨 POLICE STOP! What do you do?");
            Console.WriteLine("A) Run away");
            Console.WriteLine("B) Pay the ticket");

            var choice = Console.ReadLine().ToUpper();

            if (choice == "A")
            {
                Console.WriteLine("⚠️ You tried to escape! Risky move!");
            }
            else
            {
                Console.WriteLine("✅ Good! You paid the ticket.");
            }
        }
    }
}