using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealership
{
    class Program
    {
        static void Main(string[] args)
        {
            //You are writing an application for a car dealership.
            //Create a car class with some non-static fields and a static field to record the total number of cars in the program.
            //Instantiate 3 objects
            //Assign values to their properties
            //Increment the total number of cars each time you instantiate another car object
            //Display the values of the objects and the static field.


            //instantiate 3 cars
            Car mini = new Car("MiniCooper", "hatchback", 10000);       

            Car mazda = new Car("mazda", "2", 12000);
          
            Car peugeot = new Car("peugeot", "407", 15000);

            //program start
            Console.WriteLine("We have a total of " + Car.totalCars + " cars.");


        }
       
    }
}
