using System;
using System.Collections.Generic;
using System.Text;

namespace task13
{
    public class Stack
    {
        private int[] array = new int[10];
        private int count;

        public int Count { get => count; set => count = value; }

        public Stack()
        {
            count = 0;
        }

        public void Push(int element)
        {
            if (count == 10)
                throw new Exception("Array is full");
            array[count++] = element;
        }

        public int Pop()
        {
            if (count == 0)
                throw new Exception("Array is empty");
            int temp = array[--count];
            array[count] = default;
            return temp;
        }

        public int Peek()
        {
            if (count == 0)
                throw new Exception("Array is empty");
            return array[count - 1];
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = count - 1; i >= 0; i--)
            {
                stringBuilder.Append(array[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
