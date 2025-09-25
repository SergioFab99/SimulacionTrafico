using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimulacionTrafico
{
    public class Intersection
    {
        private string _name;
        private List<Street> _streets;

        public Intersection(string name)
        {
            _name = name;
            _streets = new List<Street>();
        }

        public void AddStreet(Street street)
        {
            _streets.Add(street);
        }

        public int GetStreetCount()
        {
            return _streets.Count;
        }

        public string GetName()
        {
            return _name;
        }
    }
}
