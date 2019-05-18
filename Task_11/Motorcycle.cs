using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Motorcycle
    {
        private int _id;
        private string _name;
        private string _model;
        private int _year;
        private int _odometer;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public int Odometer { get => _odometer; set => _odometer = value; }

        public Motorcycle(int id, string name, string model, int year, int odometer)
        {
            _id = id;
            _name = name;
            _model = model;
            _year = year;
            _odometer = odometer;
        }
    }
}
