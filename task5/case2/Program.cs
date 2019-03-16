using System;

namespace case2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            try
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    array[i] = int.Parse(Console.ReadLine());
                }
            }

            catch (ArgumentNullException )
            {
                return;
            }
            catch (FormatException)
            {
                return;
            }

            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();

            int number, index;

            try
            {
                number = int.Parse(Console.ReadLine());
                index = int.Parse(Console.ReadLine());
            }
            catch (ArgumentNullException)
            {
                return;
            }
            catch (FormatException)
            {
                return;
            }

            if (index < 1 || index > array.Length - 1)
            {
                return;
            }

            for ( int i = index - 1; i < array.Length; i++)
            {
                int element = array[i];
                array[i] = number;
                number = element;
            }
            foreach (int i in array)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
