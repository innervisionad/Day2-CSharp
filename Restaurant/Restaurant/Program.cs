using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantEncapsulationExercise
{
    class Program
    {
        public class Meal
        {
            public string name;
            public decimal price;
            public decimal cost;
            public void addMeal(string name, decimal price, decimal cost)
            {
                this.name = name;
                this.price = price;
                this.cost = cost;
            }
            public static void cookMeal(Meal meal)
            {
                Console.WriteLine("The meal {0} has been cooked.", meal.name);
                
            }
        }
        public class Order
        {
            public void takeOrder(Meal meal)
            {
                Console.WriteLine("The meal {0} has been ordered.", meal.name);
            }
        }

        public class account
        {
            public decimal balance = 0;
            public void updateBal(Meal meal)
            {
                balance = balance + meal.price;
                balance = balance - meal.cost;               
            }
            public void totalProfit()
            {
                Console.WriteLine("Today's profits are £{0}", this.balance.ToString());
            }
        }


        static void Main(string[] args)
        {
            account todaysMoney = new account();            
            //add some meals data
            Meal steak = new Meal();
            steak.addMeal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);


            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            todaysMoney.updateBal(steak);

            

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            todaysMoney.updateBal(pumpkinRisotto);

            todaysMoney.totalProfit();
        }
    }
}