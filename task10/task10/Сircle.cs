using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public class Сircle : Figure
    {
        public int Radius { get => Radius; set => Radius = value; }

        public Сircle(int _radius)
        {
            Radius = _radius;
            Name = GetType().ToString() + Radius;
        }

        override internal double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
