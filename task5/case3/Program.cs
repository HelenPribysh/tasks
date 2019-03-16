using System;

namespace case3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3] { 1, 2, 3 };
            Array.Reverse(arr);
            foreach (int i in arr)
                Console.WriteLine(i);
            MyReverse(arr);

        }

        public static void MyReverse(int[] array)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                var element = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = element;
            }
            foreach (int i in array)
                Console.WriteLine(i);
        }
    }
}
