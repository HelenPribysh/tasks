using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Task_11
{
    class Repository : IRepositiry
    {
        private List<Motorcycle> dbMotorcycles;// = new ArrayList{};
        public Repository()
        {
            dbMotorcycles = new List<Motorcycle>();
            dbMotorcycles.Add(new Motorcycle(1, "Name1", "Model1", 1, 1));
            dbMotorcycles.Add(new Motorcycle(2, "Name2", "Model2", 2, 2));
            dbMotorcycles.Add(new Motorcycle(3, "Name3", "Model3", 3, 3));
        }
        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            foreach (Motorcycle m in dbMotorcycles)
            {
                if (motorcycle.Id == m.Id)
                {
                    Console.WriteLine("Such Id is already exist");
                    return;
                }
            }
            dbMotorcycles.Add(motorcycle);
        }

        public void DeleteMotorcycle(int id)
        {
            List<Motorcycle> dbCopy = new List<Motorcycle>(dbMotorcycles);
            foreach (Motorcycle m in dbCopy)
            {
                if (m.Id == id)
                {
                    dbMotorcycles.Remove(m);
                }
            }
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            List<Motorcycle> dbCopy = dbMotorcycles;
            foreach (Motorcycle m in dbCopy)
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }

        public List<Motorcycle> GetMotorcycles()
        {
            return dbMotorcycles;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            List<Motorcycle> dbCopy = dbMotorcycles;
            foreach (Motorcycle m in dbCopy)
            {
                if (motorcycle.Id == m.Id)
                {
                    dbMotorcycles.Remove(m);
                    dbMotorcycles.Add(motorcycle);
                    return;
                }
            }
        }
    }
}

