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
    }
}
