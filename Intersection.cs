using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionTrafico
{
    internal class Intersection
    {
        private string _name;
        private List<Street> _streets;

        internal Intersection(string name)
        {
            _name = name;
            _streets = new List<Street>();
        }

        internal void AddStreet(Street street)
        {
            _streets.Add(street);
        }

        internal int GetStreetCount()
        {
            return _streets.Count;
        }

        internal string GetName()
        {
            return _name;
        }
    }
}
