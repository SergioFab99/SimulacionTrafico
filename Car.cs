using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulacionTrafico
{
    internal class Car
    {
        private string _model;
        private int _speed;
        private bool _isMoving;

        internal Car(string model)
        {
            _model = model;
            _speed = 0;
            _isMoving = false;
        }

        internal void Start()
        {
            _isMoving = true;
            _speed = 30;
        }

        internal void Stop()
        {
            _isMoving = false;
            _speed = 0;
        }

        internal int GetSpeed()
        {
            return _speed;
        }

        internal string GetModel()
        {
            return _model;
        }

        internal bool IsMoving()
        {
            return _isMoving;
        }
    }
}