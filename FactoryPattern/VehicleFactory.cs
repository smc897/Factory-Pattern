using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numWheels) {
            switch (numWheels) {
                case 2: {
                        return new Motorcycle();
                        break;
                    }
                case 3: {
                        return new Tricycle();
                        break;
                    }
                case 4: {
                        return new Car();
                        break;
                    }
                default: {
                        return new Car();
                        break;
                    }
            }
        }
    }
}
