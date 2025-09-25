using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionTrafico
{
    public class Street
    {
        private string _name;
        private List<Car> _cars;
        private List<TrafficLight> _trafficLights;

        public Street(string name)
        {
            _name = name;
            _cars = new List<Car>();
            _trafficLights = new List<TrafficLight>();
        }

        public void AddCar(Car car)
        {
            _cars.Add(car);
        }

        public void AddTrafficLight(TrafficLight light)
        {
            _trafficLights.Add(light);
        }

        public int GetCarCount()
        {
            return _cars.Count;
        }

        public string GetName()
        {
            return _name;
        }
    }
}