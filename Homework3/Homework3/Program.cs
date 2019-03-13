using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {            
            double number1 = 0, number2 = 0, sum = 0;
            char opperator;
            try
            {
                Console.WriteLine("Введите первое число");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                number2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите оператор + или -");
                opperator = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Введите Ваш результат");
                sum = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                return;
            }
            double result;
            if (Object.Equals(opperator, '+'))
            {
                result = getSum(number1, number2);
            }
            else if (Object.Equals(opperator, '-'))
            {
                result = getResidual(number1, number2);
            }
            else
            {
                Console.WriteLine("Недопустимый оператор");
                return;
            }
            //1
            //Console.WriteLine(getSum(number1, number2)); 

            if (Object.Equals(sum, result))
            {
                Console.WriteLine("Правильно");
            }
            else
            {
                Console.WriteLine("Неправильно");
                if (sum < result)
                {
                    Console.WriteLine("Должно быть больше");
                }
                else
                {
                    Console.WriteLine("Должно быть меньше");
                }
            }
        }
        public static double getSum(double number1, double number2)
        {            
            return number1 + number2;
        }
        public static double getResidual(double number1, double number2)
        {
            return number1 - number2;
        }
    }
}
