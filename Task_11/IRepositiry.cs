using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    interface IRepositiry
    {
        Motorcycle GetMotorcycleByID(int id);
        List<Motorcycle> GetMotorcycles();
        void CreateMotorcycle(Motorcycle motorcycle);
        void UpdateMotorcycle(Motorcycle motorcycle);
        void DeleteMotorcycle(int id);
    }
}
