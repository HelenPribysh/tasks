using System;
using System.Collections.Generic;
using System.Text;

namespace task13.Extention
{
    public static class Extention
    {
        public static int GetFreeCapacity(this Stack stack)
        {
            return 10 - stack.Count;
        }

        public static int GetFreeCapacity<T>(this StackT <T> stackT)
        {
            return 10 - stackT.Count;
        }
    }
}
