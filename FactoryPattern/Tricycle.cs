using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Tricycle: IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("The tricycle is driving");
        }
    }
}
