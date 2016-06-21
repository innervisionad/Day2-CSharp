using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_cars
{
    class Vehicle
    {
        public string name;
        public string model;
        public string shift;
        public int wheels;

        public Vehicle(string name, string model, string shift)
        {
            this.name = name;
            this.model = model;
            this.shift = shift;
        }
        public virtual void getWheels()
        {
            Console.WriteLine("This vehicle has {0} wheels.", this.wheels);
        }
    }
}
