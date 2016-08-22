using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        public int sellPrice;
        public int mileage;
        public bool isNew;
        public bool sold;
        
        public static int carTotal;
        public static int carSold;
        public static int usedCars;

        public Car(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;

            this.isNew = true;
            this.sold = false;
            Car.carTotal++;
        }

        public Car(string make, string model, int price, int mileage)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.mileage = mileage;

            this.isNew = false;
            this.sold = false;
            Car.usedCars++;
            Car.carTotal++;
        }

        public void SellCar(bool sold, int sellPrice)
        {
            this.sold = sold;

            if (isNew == false)
            {
                Car.usedCars--;
            }

            this.sellPrice = sellPrice;
            Car.carSold++;
            Car.carTotal--;
        }

        public void ListCar()
        {
            Console.WriteLine("\n" + "The details of the car is: ");
            Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00, Mileage: {3}.", make, model, price, mileage);

            if (sold == true)
            {
                Console.WriteLine("This car has been sold, for a total of: £{0:N0}.00.", sellPrice);
            }
            else
            {
                Console.WriteLine("This car has not been sold yet.");
            }
        }

        public static void TotalSales(List<Car> cars)
        {
            int totalSales = 0;
            int totalStock = 0;

            foreach (Car car in cars)
            {
                if (car.isNew == false) {
                    Console.WriteLine("\n" + "The details of the car is: ");
                    Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00, Mileage: {3}.", car.make, car.model, car.price, car.mileage);
                }
                else {
                    Console.WriteLine("\n" + "The details of the car is: ");
                    Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00.", car.make, car.model, car.price);
                }

                if (car.sold == true) {
                    Console.WriteLine("This car has been sold, for a total of: £{0:N0}.00.", car.sellPrice);
                    totalSales += car.sellPrice;
                }
                else {
                    Console.WriteLine("This car has not been sold yet.");
                    totalStock += car.price;
                }
            }

            if (Car.carTotal == 0){
                Console.WriteLine("\n" + "We have sold all our available cars!");
            }
            else {
                Console.WriteLine("\n" + "Total number of car in stock right now: " + Car.carTotal);
            }

            if (Car.usedCars == 0) {
                Console.WriteLine("\n" + "We currently have no second-hand cars stocked.");
            }
            else {
                Console.WriteLine("\n" + "The total number of second-hand cars currently stocked is: {0}", Car.usedCars);
            }

            Console.WriteLine("\n" + "The total number of cars sold so far is: {0}", Car.carSold);
            Console.WriteLine("\n" + "The total value of all the cars sold so far equals: £{0:N0}.00", totalSales);
            Console.WriteLine("\n" + "The value of all our currently stocked cars equals: £{0:N0}.00" + "\n", totalStock);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();

            Car carOne = new Car("Mazda", "Mazda3", 6000, 60000);
            cars.Add(carOne);

            Car carTwo = new Car("Honda", "Civic", 5500, 65000);
            cars.Add(carTwo);

            Car carThree = new Car("BMW", "3 Series", 10000);
            cars.Add(carThree);

            Car carFour = new Car("Ford", "Fiesta", 8000);
            cars.Add(carFour);

            Car carFive = new Car("Volkswagen", "Polo", 9000, 50000);       
            cars.Add(carFive);

            carOne.SellCar(true, 7000);
            carTwo.SellCar(true, 6500);
            carThree.SellCar(true, 9500);
            carFour.SellCar(true, 10000);
            carFive.SellCar(true, 9500);

            Car.TotalSales(cars);

        }
    }
}
