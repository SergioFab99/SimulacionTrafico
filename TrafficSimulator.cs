using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionTrafico
{
    internal class TrafficSimulator
    {
        private List<Street> _streets;
        private List<Intersection> _intersections;
        private int _currentHour;
        private bool _isWeekend;
        private bool _isNight;
        private readonly Random _random; // agregado para eventos

        internal TrafficSimulator()
        {
            _streets = new List<Street>();
            _intersections = new List<Intersection>();
            _currentHour = 8;
            _isWeekend = false;
            _isNight = false;
            _random = new Random();
        }

        internal void AddStreet(Street street)
        {
            _streets.Add(street);
        }

        internal void AddIntersection(Intersection intersection)
        {
            _intersections.Add(intersection);
        }

        internal void StartSimulation()
        {
            Console.WriteLine("Traffic simulation started!");
            UpdateTraffic();
            ShowStats();
        }

        internal void UpdateTraffic()
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

        internal void ShowStats()
        {
            Console.WriteLine($"Current hour: {_currentHour}:00");
            Console.WriteLine($"Is weekend: {_isWeekend}");
            Console.WriteLine($"Is night: {_isNight}");
            Console.WriteLine($"Total streets: {_streets.Count}");
            Console.WriteLine($"Total intersections: {_intersections.Count}");
        }

        internal void SetNightMode()
        {
            _isNight = true;
        }

        internal bool IsPeakHour()
        {
            return (_currentHour >= 7 && _currentHour <= 9) || (_currentHour >= 17 && _currentHour <= 19);
        }

        internal bool IsWeekendNight()
        {
            return _isWeekend && (_currentHour >= 18 || _currentHour < 6);
        }

        internal void SimulateTrafficEvent()
        {
            int roll = _random.Next(0, 100);
            if (roll < 15)
            {
                Console.WriteLine("Evento: 🚧 Obras en la vía. Velocidad reducida.");
            }
            else if (roll < 25)
            {
                Console.WriteLine("Evento: 🚓 Control policial. Flujo ralentizado.");
            }
            else if (roll < 30)
            {
                Console.WriteLine("Evento: 💥 Accidente menor. Se genera congestión.");
            }
            else if (roll < 35 && _isNight)
            {
                Console.WriteLine("Evento: 🌙 Menos tráfico por la noche. Flujo mejora.");
            }
        }
    }
}