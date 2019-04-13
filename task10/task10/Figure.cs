using System;
using System.Collections.Generic;
using System.Text;

namespace task10
{
    public abstract class Figure 
    {
        public string Name { get => Name; set => Name = value; }

        internal abstract double GetSquare();
    }
}
