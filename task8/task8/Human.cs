using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    public class Human
    {
        private string firstName;
        private string secondName;
        private Passport pasport;
        private Luggage luggage;
        private string flightNumber;
        private bool withTicket;
        private bool isHumanClear;        

        public Human()
        { }

        public Human(string _firstName, string _secondName, Passport _pasport, Luggage _luggage)
        {
            firstName = _firstName;
            secondName = _secondName;
            pasport = _pasport;
            luggage = _luggage;
            withTicket = false;
        }

        public Human(string _firstName, string _secondName, Passport _pasport, string _flightNumber)
        {
            firstName = _firstName;
            secondName = _secondName;
            pasport = _pasport;
            flightNumber = _flightNumber;
            withTicket = false;
        }

        public string FlightNumber { get => flightNumber; set => flightNumber = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string SecondName { get => secondName; set => secondName = value; }
        public Luggage Luggage { get => luggage; set => luggage = value; }
        public bool WithTicket { get => withTicket; set => withTicket = value; }
        public bool IsHumanClear { get => isHumanClear; set => isHumanClear = value; }
        internal Passport Pasport { get => pasport; set => pasport = value; }

        public string GetFirstAndSecondName()
        {
            return FirstName + " " + SecondName;
        }
    }
}
