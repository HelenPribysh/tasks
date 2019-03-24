using System;

namespace case1
{
    class Program
    {
        static void Main(string[] args)
        {         
            string str = Console.ReadLine();
            str = str.Replace('о', 'а').Replace('О', 'А').Replace('o', 'a').Replace('O', 'A');
            string[] separatedString = str.Split(';');
            
            foreach (string i in separatedString)
            {
                Console.WriteLine(i);
            }
        }
    }
}
