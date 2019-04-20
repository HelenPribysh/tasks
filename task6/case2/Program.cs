using System;

namespace case2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "aaa bb cccc dd eeee";
            string[] separatedStr = str.Split(' ');
            Remove(separatedStr);
            Replace(separatedStr);
            CountSymbols(str);
            Sort(separatedStr);
        }

        static void Remove(string[] separatedStr)
        {
            int longWordLength = 0;

            for (int i = 0; i < separatedStr.Length; i++)
            {
                if (separatedStr[i].Length >= longWordLength)
                {
                    longWordLength = separatedStr[i].Length;
                }
            }

            for (int i = 0; i < separatedStr.Length; i++)
            {
                if (int.Equals(separatedStr[i].Length, longWordLength))
                {
                    separatedStr[i] = string.Empty;
                }
                Console.WriteLine(separatedStr[i]);
            }
        }

        static void Replace(string[] separatedStr)
        {
            int longWordLength = 0;
            int shortWordLength = int.MaxValue;
            for (int i = 0; i < separatedStr.Length; i++)
            {
                if (separatedStr[i].Length >= longWordLength)
                {
                    longWordLength = separatedStr[i].Length;
                }

                if (separatedStr[i].Length <= shortWordLength)
                {
                    shortWordLength = separatedStr[i].Length;
                }
            }

            if (int.Equals(longWordLength, shortWordLength))
            {
                Console.WriteLine("All words have the same length");
                return;
            }

            for (int i = 0; i < separatedStr.Length; i++)
            {
                if (int.Equals(separatedStr[i].Length, shortWordLength))
                {
                    for (int j = i; j < separatedStr.Length; j++)
                    {
                        if (int.Equals(separatedStr[j].Length, longWordLength))
                        {
                            string temp = separatedStr[i];
                            separatedStr[i] = separatedStr[j];
                            separatedStr[j] = temp;
                            i = j;
                            break;
                        }
                    }
                }
            }
            foreach (string i in separatedStr)
                Console.WriteLine(i);
        }

        static void CountSymbols(string str)
        {
            int beginOfSymbols = 32, endOfSymbols = 64;
            int numberOfLetter = 0, numberOfSigns = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((int)str[i] >= beginOfSymbols && (int)str[i] <= endOfSymbols)
                {
                    numberOfSigns++;
                }

                else
                {
                    numberOfLetter++;
                }
            }
            Console.WriteLine($"{numberOfSigns} {numberOfLetter}");
        }

        static void Sort(string[] separatedStr)
        {
            for (int i = separatedStr.Length - 2; i >= 0; i--)
            {
                for (int j = i; j < separatedStr.Length - 1
                    && separatedStr[j + 1].Length > separatedStr[j].Length; j++)
                {
                    string temp = separatedStr[j + 1];
                    separatedStr[j + 1] = separatedStr[j];
                    separatedStr[j] = temp;
                }
            }
            foreach (string i in separatedStr)
                Console.WriteLine(i);
        }
    }
}
