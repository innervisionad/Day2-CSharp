using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorcycleSalesman
{
    class motorcycle : Vehicle
    {
        public motorcycle(string name, string model, int price)
            :base(name, model, price)
        {
            this.wheels = 2;
        }
        public void wheelie()
        {
            Console.WriteLine("I'm doing a wheelie on a {0}", this.model);
        }
    }
}
