using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    public class PasportControl
    {
        public void Check(Human human)
        {
            Console.WriteLine("Welcome, provide your pasport");
            if (human.Pasport != null)
            {
                while (true)
                {
                    Passport passport = human.Pasport;
                    if (!passport.IsVisaExist)
                    {
                        Console.WriteLine("You dont have, you can buy");

                        passport.IsVisaExist = true;
                        human.Pasport = passport;
                    }
                    else
                    {
                        Console.WriteLine("Have a good flight!");
                        break;
                    }
                }
            }
        }

    }
}
