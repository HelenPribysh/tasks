using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    public class Airport
    {
        public void WelcomeToAirport()
        {
            CheckIn checkIn = new CheckIn();
            SecurityCheck securityCheck = new SecurityCheck();
            PasportControl pasportControl = new PasportControl();
            Human human;             
            
                Console.WriteLine("Enter your first name and second name or pasport");
                human = checkIn.PerfomRegistration(Console.ReadLine());

                if (human == null)
                {
                    Console.WriteLine("You haven't registrated. Please, try again.");
                }
            
            Console.WriteLine($"{human.FirstName}, Welcome to Airport.");
            checkIn.SetAditionalValues(human);
            securityCheck.Check(human);
            pasportControl.Check(human);
        }
    }
}           
