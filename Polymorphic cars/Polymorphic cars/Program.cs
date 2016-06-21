using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphic_cars
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program which displays the number of wheels different vehicles have, using polymorphism
            //Use the virtual, override and new keywords in method signatures

            Bike myBike = new Bike("Yamaha", "Viper");
            Bike RobBike = new Bike("ducatti", "Emperor");
            Car myCar = new Car("Mazda", "2", "manual");
            Vehicle RobPlane = new Vehicle("Spitfire", "mach 2", "manual");

            myCar.getWheels();
            (myBike as Vehicle).getWheels();

            myBike.getWheels();
            RobBike.getWheels();
            RobPlane.getWheels();


        }
    }
}
