using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorcycleSalesman
{
    class Program
    {
        static void Main(string[] args)
        {
            //Our car dealer wants to add motorcycles to his car showroom
            //Add a vehicle base class to the previous code
            //Then add a motorcycle class
            //Car and motorcycle should both inherit from Vehicle
            //Implement methods to Add and Sell and see how much code you can reuse via inheritance

            Car myCar = new Car("toyota", "prius", 7000);
            motorcycle myBike = new motorcycle("yamaha", "viper", 4000);
            Console.WriteLine(myBike.wheels);
            myBike.sellVehicle();
            myCar.sellVehicle();
            myBike.wheelie();
        }
    }
}
