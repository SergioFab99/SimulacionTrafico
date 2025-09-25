using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTrafico
{
    public class Car
    {
        private string _model;
        private int _speed;
        private bool _isMoving;

        public Car(string model)
        {
            _model = model;
            _speed = 0;
            _isMoving = false;
        }

        public void Start()
        {
            _isMoving = true;
            _speed = 30;
        }

        public void Stop()
        {
            _isMoving = false;
            _speed = 0;
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public string GetModel()
        {
            return _model;
        }

        public bool IsMoving()
        {
            return _isMoving;
        }
    }
}