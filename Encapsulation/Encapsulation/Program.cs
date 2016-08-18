using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantEncapsulationExercise
{
    public class Meal
    {
        public string name;
        public decimal price;
        public decimal cost;

        public Meal(string name, decimal price, decimal cost)
        {
            this.name = name;
            this.price = price;
            this.cost = cost;        
        }

       public static void cookMeal(Meal meal)
        {
            Console.WriteLine("\nThe meal {0} has been cooked.", meal.name);
        }

    }

    public class Sales
    {
        public static decimal balance { get; set; }

        public static decimal doSales(Meal meal)
        {
            balance += meal.price;
            balance -= meal.cost;

            return balance;
        }

    }
    public class Order
    {
        public Order(Meal meal)
        {
            Console.WriteLine("\nThe meal {0} has been ordered.", meal.name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //decimal balance = 0;

            //add some meals data
            Meal steak = new Meal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal("pumpkinRisotto", 10.00M, 1.00M);

            Order order1 = new Order(steak);
            Sales.doSales(steak);

            Order order2 = new Order(pumpkinRisotto);
            Sales.doSales(pumpkinRisotto);

            Order order3 = new Order(fajitas);
            Sales.doSales(fajitas);

            Meal.cookMeal(steak);
            Meal.cookMeal(pumpkinRisotto);
            Meal.cookMeal(fajitas);

            Console.WriteLine("\nTonight in the restaurant, we made £{0:N2}.", Sales.balance);
           
        }
    }
}