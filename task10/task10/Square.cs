using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public class Foursquare : Figure
    {
        public int Side { get => Side; set => Side = value; }     

        public Foursquare(int _side)
        {
            Side = _side;
            Name = GetType().ToString() + Side;
        }

        override internal double GetSquare()
        {
            return Side * Side;
        }

    }

}
