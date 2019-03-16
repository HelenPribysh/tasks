﻿using System;

namespace case1
{
    class Program
    {
        const int size = 4;

        static void Main(string[] args)
        {
            // Array1

            int[] array1 = new int[size];
            Random random = new Random();
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = random.Next(0, 100);
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();

            // Array2

            int[] array2 = new int[size];
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array2[i]} ");
            }
            Console.WriteLine();

            // The sum of array1 and array2

            int[] sumArray = new int[size];
            for (int i = 0; i < sumArray.Length; i++)
            {
                sumArray[i] = array1[i] + array2[i];
            }

            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.Write($"{sumArray[i]} ");
            }
            Console.WriteLine();
        }
    }
}
