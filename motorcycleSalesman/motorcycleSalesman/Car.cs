using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorcycleSalesman
{
    class Car : Vehicle
    {
        public int doors = 4;
        public Car(string name, string model, int price)
            :base(name, model, price)
        { }
       
       
    }
}
