using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    class SecurityCheck
    {
        public void Check(Human human)
        {
            Console.WriteLine("Welcome to security checking, provide your luggage");
            if (human.Luggage != null)
            {
                while (true)
                {
                    Luggage luggage = human.Luggage;
                    if (luggage.IsForbiddenSubject)
                    {
                        Console.WriteLine("Remove your forbidden subject");

                        luggage.IsForbiddenSubject = false;
                        human.Luggage = luggage;
                    }
                    else
                    {
                        Console.WriteLine("Go to the pasport control");
                        break;
                    }
                }
            }
                human.IsHumanClear = true;
        }
    }
}
