using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTrafico
{
    internal class TrafficLight
    {
        private string _color;
        private bool _isWorking;

        internal TrafficLight()
        {
            _color = "Red";
            _isWorking = true;
        }

        internal void ChangeColor()
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

        internal string GetColor()
        {
            return _color;
        }

        internal void Break()
        {
            _isWorking = false;
            _color = "Broken";
        }

        internal bool IsWorking()
        {
            return _isWorking;
        }
    }
}