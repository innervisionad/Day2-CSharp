using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_cars
{
    class Bike : Vehicle
    {
        public Bike(string name, string model)
            :base(name, model, "manual")
        {
            this.wheels = 2;
        }


        new public void getWheels()
        {
            Console.WriteLine("This Bike has {0} wheels.", this.wheels);
        }
    }
}
