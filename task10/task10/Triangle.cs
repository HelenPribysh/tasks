using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public class Triangle : Figure
    {
        private int side;

        public Triangle(int _side)
        {
            Side = _side;
            Name = GetType().ToString() + Side;
        }

        public int Side { get => side; set => side = value; }

        override internal double GetSquare()
        {
            return Side * Side * Math.Sqrt(3) / 4;
        }
    }
}
