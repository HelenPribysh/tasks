using System;

namespace task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure[] figures = new Figure[30];
            int maxSideLenth = 10;
            int count = 0;

            for (int i = 1; i <= maxSideLenth; i++)
            {
                figures[count] = new Triangle(i);
                figures[++count] = new Сircle(i);
                figures[++count] = new Foursquare(i);
                count++;
            }

            foreach (Figure figure in figures)
            {
                Console.WriteLine($"This is {figure.Name}. " +
                    $"CLR Type is {figure.GetType()}. " +
                    $"Square is {figure.GetSquare()}");
            }
        }
    }
}
