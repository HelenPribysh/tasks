using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    public class Luggage
    {
        private double mass;
        private bool isHandLuggage;
        private bool isForbiddenSubject;

        public double Mass { get => mass; set => mass = value; }
        public bool IsHandLuggage { get => isHandLuggage; set => isHandLuggage = value; }
        public bool IsForbiddenSubject { get => isForbiddenSubject; set => isForbiddenSubject = value; }

        public Luggage()
        {
            mass = 60.0;
            isHandLuggage = true;
            isForbiddenSubject = true;

    }

        public Luggage(double _mass)
        {
            mass = _mass;
            isHandLuggage = false;
            isForbiddenSubject = true;
        }

        public Luggage(double _mass, bool _isHandLuggage)
        {
            mass = _mass;
            isHandLuggage = _isHandLuggage;
            isForbiddenSubject = true;
        }

    }
}
