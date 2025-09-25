using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTrafico
{
    public class TrafficLight
    {
        private string _color;
        private bool _isWorking;

        public TrafficLight()
        {
            _color = "Red";
            _isWorking = true;
        }

        public void ChangeColor()
        {
            switch (_color)
            {
                case "Red":
                    _color = "Green";
                    break;
                case "Green":
                    _color = "Yellow";
                    break;
                case "Yellow":
                    _color = "Red";
                    break;
            }
        }

        public string GetColor()
        {
            return _color;
        }

        public void Break()
        {
            _isWorking = false;
            _color = "Broken";
        }

        public bool IsWorking()
        {
            return _isWorking;
        }
    }
}