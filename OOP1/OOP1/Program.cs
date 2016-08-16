using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Car
    {
        public string makeModel;
        public int price;
        public int soldPrice;
        public int mileage;
        public bool sold;

        //List<Car> cars = new List<Car>;
      
        public static int carTotal;
        public static int carSold;

        public void AddCar(string makeModel, int price)
        {
            this.makeModel = makeModel;
            this.price = price;
            this.sold = false;
            Car.carTotal++;
        }

        public void SellCar(bool sold, int soldPrice)
        {
            this.sold = sold;
            this.soldPrice = soldPrice;
            Car.carSold++;
            Car.carTotal--;
        }

        public void ListCar()
        {
            Console.WriteLine("\n" + "The details of the car is: ");
            Console.WriteLine("Make and model: {0}, price being: £{1:N0}, with mileage: {2}", makeModel, price, mileage);

            if (sold == true)
            {
                Console.WriteLine("This car has been sold, for a total of: £{0:N0}.", soldPrice);
            }
            else
            {
                Console.WriteLine("This car has not been sold yet.");
            }
        }

        public static void DisplayAllCars(List<Car> cars)
        {
            int totalSales;
            int totalStock;

            foreach (Car car in cars)
            {
                //Console.WriteLine("\n" + "The details of the car is: ");
                //Console.WriteLine("Make and model: {0}, price being: £{1:N0}, with mileage: {2}", makeModel, price, mileage);
            }
        }


        /*public static int TotalSales()
        {
            this.cars
            foreach (Car c in cars)
            {

            }
        }*/
    }


    class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car();
            Car.carTotal++;
            carOne.makeModel = "Mazda / Mazda3";
            carOne.price = 6000;
            carOne.sold = false;
            carOne.mileage = 60000;
            
            Car carTwo = new Car();
            Car.carTotal++;
            carTwo.makeModel = "Honda / Civic";
            carTwo.price = 5500;
            carTwo.mileage = 65000;

            Car carThree = new Car();
            Car.carTotal++;
            carThree.makeModel = "BMW / 3 Series";      
            carThree.price = 10000;
            carThree.sold = false;

            Car carFour = new Car();
            carFour.AddCar("Ford / Fiesta", 8000);
        
            Car carFive = new Car();
            carFive.AddCar("Volkswagen / Polo", 9000);
            carFive.mileage = 50000;

            carTwo.SellCar(true, 6500);
            carFour.SellCar(true, 10000);
            carFive.SellCar(true, 9500);

            carOne.ListCar();
            carTwo.ListCar();
            carThree.ListCar();
            carFour.ListCar();
            carFive.ListCar();

            Console.WriteLine("Total number of car in stock right now: " + Car.carTotal);
            Console.WriteLine("\n" + "The total number of cars sold so far is {0}.", Car.carSold);

        }
    }
}
