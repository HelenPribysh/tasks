using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public class Foursquare : Figure
    {
        private int side;

        public Foursquare(int _side)
        {
            Side = _side;
            Name = GetType().ToString() + Side;
        }

        public int Side { get => side; set => side = value; }

        override internal double GetSquare()
        {
            return Side * Side;
        }

    }

}
