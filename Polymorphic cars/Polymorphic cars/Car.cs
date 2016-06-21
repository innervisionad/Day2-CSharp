using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_cars
{
    class Car : Vehicle
    {
        public Car(string name, string model, string shift)
            : base(name, model, shift)
        {
        this.wheels = 4;
        }
        public override void getWheels()
        {
            Console.WriteLine("wheels on a car go round and round! Beep Beep!");
        }
    }
}


