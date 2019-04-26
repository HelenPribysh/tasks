﻿using System;
using System.Collections.Generic;
using System.Text;

namespace task13
{
    public class StackT<T>
    {
        private T[] array = new T[10];
        private int count;

        public int Count { get => count; set => count = value; }

        public StackT()
        {
            count = 0;
        }

        public void Push(T element)
        {
            if (count == 10)
                throw new Exception();
            array[count++] = element;
        }

        public T Pop()
        {
            if (count == 0)
                throw new Exception("Array is full");
            T temp = array[--count];
            array[count] = default;
            return temp;
        }

        public T Peek()
        {
            if (count == 0)
                throw new Exception();
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
