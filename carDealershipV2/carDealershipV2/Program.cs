using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carDealershipV2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Write a non-static (instance) method to add some cars to the program
            //Add another non-static method
            //e.g.to list the details of each car or record that a car has been sold(you may need to add a ‘sold’ field to the car class)

            //instantiate 3 cars

            Car mini = new Car("MiniCooper", "hatchback", 10000);
          

            Car mazda = new Car("mazda", "2", 12000);
            

            Car peugeot = new Car("peugeot", "407", 15000);

            //program start
            
            mini.getPrice();
            mazda.getPrice();
            peugeot.getPrice();

            Car.numOfCars();
        }
    }
}
