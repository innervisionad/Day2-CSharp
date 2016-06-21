using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorcycleSalesman
{
    class Vehicle
    {
        public string name;
        public string model;
        public int price;
        public int wheels = 4;

        public Vehicle(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
        }

        public void sellVehicle()
        {
            Console.WriteLine("We just sold a {0} at {1}", this.model, this.price);
        }
        
    }
}
