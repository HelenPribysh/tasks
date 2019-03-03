using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            //3а
            double a = 1.1;
            int b;
            b = (int)a;

            int c = 100;
            short d;
            d = (short)c;

            double e = 2.2;
            float f;
            f = (float)e;

            //3b
            int a1 = 1;
            double b1;
            b1 = a1;

            short c1 = 100;
            int d1;
            d1 = c1;

            float e1 = 2.2f;
            double f1;
            f1 = e1;

            //3c
            int a2 = 5;
            object b2;
            b2 = a2;

            //3d
            object a3 = 1;
            int b3;
            b3 = (int) a3;

            //4a
            string a4 = "1";
            String b4 = "2";
            Console.WriteLine("{0}, {1}", a4.GetType(), b4.GetType());
            Console.ReadKey();
        }
    }
}
