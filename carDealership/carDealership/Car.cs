using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership
{
    class Car
    {
        public string name;
        public string model;
        public int price;

        public static int totalCars = 0;

        public Car(string name, string model, int price)
        {
            this.name = name;
            this.model = model;
            this.price = price;
            totalCars += 1;
        }
    }
}
