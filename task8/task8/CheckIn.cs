using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;

namespace task8
{
    public class CheckIn
    {
        private ArrayList Passangers = new ArrayList()
        {
            new Human("Lena", "Grey", new Passport("AA0111117"), "A01115"),
            new Human("Anna", "Brown", new Passport("AB1111117"), "A11115"),
            new Human("A", "A", new Passport("AB2111117"), "A21115")
        };        

        public Human PerfomRegistration(string inputValue)
        {
            Human human = new Human();
            if (IsHumanName(inputValue))
            {
                foreach (Human passanger in Passangers)
                {
                    if (Equals(passanger.GetFirstAndSecondName(), inputValue))
                    {
                        return passanger;
                    }                    
                }
                string[] str = inputValue.Split(" ");
                human.FirstName = str[0];
                human.SecondName = str[1];
            }
            else if (IsPassport(inputValue))
            {
                foreach(Human passanger in Passangers)
                {
                    if (Equals(passanger.Pasport.PasportNumber, inputValue))
                    {
                        return passanger;
                    }
                }
                human.Pasport = new Passport(inputValue);
            }
            //else if (IsFlightNumber(inputValue))
            //{
            //    foreach (Human passanger in Passangers)
            //    {
            //        if (Equals(passanger.FlightNumber, inputValue))
            //        {
            //            return passanger;
            //        }
            //    }
            //}
            return SetNameOrPassport(human);
        }
        private Human SetNameOrPassport(Human human)
        {
            if (human.FirstName == null)
            {
                Console.WriteLine("Enter First Name and Second Name");

                string[] str = Console.ReadLine().Split(" ");
                human.FirstName = str[0];
                human.SecondName = str[1];
            }
            else
            {
                Console.WriteLine("Enter passport number");
                string str = Console.ReadLine();
                human.Pasport = new Passport(str);
            }
            return human;
        }

        private bool IsHumanName(string inputValue)
        {
            return inputValue.Split(' ').Length == 2;
        }

        private bool IsPassport(string inputValue)
        {
            if (inputValue.Length == 9)
            {
                string pattern = @"^[A-Z]{2}\d[0-9]{3,7}";
                return Regex.IsMatch(inputValue, pattern);
            }
            return false;
        }

        private bool IsFlightNumber(string inputValue)
        {
            if (inputValue.Length == 5)
            {
                string pattern = @"^[A-Z]{1}\d[0-9]{2,5}";
                return Regex.IsMatch(inputValue, pattern);
            }
            return false;
        }

        public Human SetAditionalValues(Human human)
        {
            CheckTicket(human);
            CheckLuggage(human);
            return human;
        }

        public void CheckTicket(Human human)
        {
            Console.WriteLine("Do you have a ticket?");
            if (String.Equals(Console.ReadLine().ToString().ToLower(), "yes"))
            {
                Console.WriteLine("Thanks for buying the ticket before registration");
            }
            else
            {
                Console.WriteLine("Okay, take your ticket");
            }
            human.WithTicket = true;
        }

        public void CheckLuggage(Human human)
        {
            Console.WriteLine("Do you have a luggage?");
            if (String.Equals(Console.ReadLine().ToString().ToLower(), "no"))
            {
                Console.WriteLine("Have a successful flight.");
            }
            else
            {
                Console.WriteLine("Enter a weight of luggage from libra.");
                double mass = Convert.ToDouble(Console.ReadLine());
                Luggage luggage = new Luggage(mass);

                if (mass <= 10.0)
                {
                    luggage.IsHandLuggage = true;
                    Console.WriteLine("You have the hand luggage.");
                }
                else
                {
                    Console.WriteLine("You have the luggage.");
                }

                human.Luggage = luggage;
            }
        }
    }
}
