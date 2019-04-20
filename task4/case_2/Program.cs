using System;

namespace case_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrySymbol = String.Empty;

            try
            {
                entrySymbol = Console.ReadLine();
            }

            catch (Exception)
            {
                return;
            }
            switch (entrySymbol.ToLower())
            {
                case "w":
                    Console.WriteLine("Figure is moving up");
                    break;
                case "s":
                    Console.WriteLine("Figure is moving down");
                    break;
                case "a":
                    Console.WriteLine("Figure is moving right");
                    break;
                case "d":
                    Console.WriteLine("Figure is moving left");
                    break;
                default:
                    Console.WriteLine("Figure don't need to move");
                    break;
            }
        }
    }
}
