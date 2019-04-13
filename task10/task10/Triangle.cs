using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public class Triangle : Figure
    {
        public int Side { get => Side; set => Side = value; }

        public Triangle(int _side)
        {
            Side = _side;
            Name = GetType().ToString() + Side;
        }

        override internal double GetSquare()
        {
            return Side * Side * Math.Sqrt(3) / 4;
        }
    }
}
