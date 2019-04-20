using System;

namespace case2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Console.WriteLine("Enter array numbers:");
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

            ArrayOutput(array);

            int number, index;
            Console.WriteLine("Enter a number and a position in array");
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

            ArrayOutput(array);
        }

        static void ArrayOutput(int[] array)
        {
            foreach (int i in array)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
    }
}
