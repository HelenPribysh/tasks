using System;
using System.Collections.Generic;
using System.Text;

namespace task8
{
    public class Passport
    {
        private string pasportNumber;
        private bool isVisaExist;

        public Passport(string _pasportNumber)
        {
            pasportNumber = _pasportNumber;
            isVisaExist = false;
        }

        public string PasportNumber { get => pasportNumber; set => pasportNumber = value; }
        public bool IsVisaExist { get => isVisaExist; set => isVisaExist = value; }
    }
}
