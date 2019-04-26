using System;
using System.Collections;
using System.Collections.Generic;
using task13.Extention;

namespace task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            StackT<char> stackT = new StackT<char>();

            stack.Push(2);
            stack.Push(3);
            stack.Pop();
            Console.WriteLine(stack.GetFreeCapacity());
            Console.WriteLine(stack.ToString());
            Console.WriteLine(stack.Peek());

            stackT.Push('a');
            stackT.Push('b');
            stackT.Pop();
            Console.WriteLine(stackT.GetFreeCapacity());
            Console.WriteLine(stackT.ToString());
            Console.WriteLine(stackT.Peek());
        }
    }
}
