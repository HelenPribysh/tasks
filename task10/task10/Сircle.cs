using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public class Сircle : Figure
    {
        private int radius;

        public Сircle(int _radius)
        {
            Radius = _radius;
            Name = GetType().ToString() + Radius;
        }

        public int Radius { get => radius; set => radius = value; }

        override internal double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
