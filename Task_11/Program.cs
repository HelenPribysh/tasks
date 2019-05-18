using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace Task_11
{
    class Program
    {
        static readonly ILog log = LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            log.Info("Hello!!");

            Repository repository = new Repository();
            repository.CreateMotorcycle(new Motorcycle(5, "Name", "Model", 2000, 6660));
            repository.DeleteMotorcycle(2);
            repository.GetMotorcycleByID(1);
            repository.UpdateMotorcycle(new Motorcycle(3, "Name.", "Model.", 2001, 6661));
            foreach (Motorcycle m in repository.GetMotorcycles())
            {
                Console.WriteLine($"{m.Id}, {m.Model}, {m.Name}, {m.Odometer}");
            }
        }
    }
}
