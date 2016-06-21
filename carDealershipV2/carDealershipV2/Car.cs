using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealershipV2
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
        public void getPrice()
        {
            Console.WriteLine("The price of {0} is {1}", this.name, this.price.ToString());
        }
        public static void numOfCars()
        {
            Console.WriteLine("We have a total of " + totalCars + " cars.");
        }
    }
}
