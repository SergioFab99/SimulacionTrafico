using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionTrafico
{
    internal class Street
    {
        private string _name;
        private List<Car> _cars;
        private List<TrafficLight> _trafficLights;

        internal Street(string name)
        {
            _name = name;
            _cars = new List<Car>();
            _trafficLights = new List<TrafficLight>();
        }

        internal void AddCar(Car car)
        {
            _cars.Add(car);
        }

        internal void AddTrafficLight(TrafficLight light)
        {
            _trafficLights.Add(light);
        }

        internal int GetCarCount()
        {
            return _cars.Count;
        }

        internal string GetName()
        {
            return _name;
        }
    }
}