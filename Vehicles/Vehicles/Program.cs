using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Test", 3);
            car.AddMilage(5000);

            car.ChangeTire(1);
        }
    }
}
