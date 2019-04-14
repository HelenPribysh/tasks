using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public abstract class Figure 
    {
        private string name;

        public string Name { get => name; set => name = value; }

        internal abstract double GetSquare();
    }
}
