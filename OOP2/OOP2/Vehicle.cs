using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{ 
    class Vehicle
    {
        public string make;
        public string model;

        public int price;
        public int sellPrice;
        public int mileage;
        public int wheels;

        public static int totalSales;
        public static int totalStock;

        public bool isNew;
        public bool sold;

        public Vehicle(string make, string model, int price)
        {
            this.make = make;
            this.model = model;
            this.price = price;

            this.sold = false;
            this.isNew = true;
        }

        public Vehicle(string make, string model, int price, int mileage)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.mileage = mileage;

            this.sold = false;
            this.isNew = false;
        }

        public void SellVehicle(string type, bool sold, int sellPrice)
        {
            if (type == "car") {
                this.sold = sold;
                if (isNew == false) { Car.usedCars--; }
                this.sellPrice = sellPrice;
                Car.carSold++;
                Car.carTotal--;
            }

            else if (type == "motorcycle") {
                this.sold = sold;
                if (isNew == false) { Motorcycle.usedCycles--; }
                this.sellPrice = sellPrice;
                Motorcycle.cycleSold++;
                Motorcycle.cycleTotal--;
            }

        }

        public static void ListVehicles(List<Vehicle> vehicle)
        {
     
            foreach (Vehicle v in vehicle)
            {
                if (v is Car)
                {
                    if (v.isNew) {
                        Console.WriteLine("\n" + "The details of the car is: ");
                        Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00, Mileage: {3}.", v.make, v.model, v.price, v.mileage);
                    }
                    else {
                        Console.WriteLine("\n" + "The details of the car is: ");
                        Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00.", v.make, v.model, v.price);
                    }
                    if (v.sold == true) {
                        Console.WriteLine("This car has been sold, for a total of: £{0:N0}.00.", v.sellPrice);
             
                    }
                    else {
                        Console.WriteLine("This car has not been sold yet.");
                   
                    }   
                }

                else if (v is Motorcycle)
                {
                    if (v.isNew == false) {
                        Console.WriteLine("\n" + "The details of the motorcycle is: ");
                        Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00, Mileage: {3}.", v.make, v.model, v.price, v.mileage);
                    }
                    else {
                        Console.WriteLine("\n" + "The details of the motorcycle is: ");
                        Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00.", v.make, v.model, v.price);
                    }

                    if (v.sold == true) {
                        Console.WriteLine("This motorycle has been sold, for a total of: £{0:N0}.00.", v.sellPrice);
       
                    }
                    else {
                        Console.WriteLine("This motorcycle has not been sold yet.");
                    }
                }
            }
        }

        public static void StockSales(List<Vehicle> vehicle)
        {
            totalSales = 0;
            totalStock = 0;
        
            foreach (Vehicle v in vehicle)
            {
                if (v is Car)
                {
                    if (v.sold == true) { totalSales += v.sellPrice;  }
                    else { totalStock += v.price; }
                }

                else if (v is Motorcycle)
                {
                    if (v.sold == true) { totalSales += v.sellPrice; }
                    else { totalStock += v.price; }
                }
            }           

            if (Car.carTotal == 0) { Console.WriteLine("\n" + "We have sold all our available cars!"); }
            else { Console.WriteLine("\n" + "Total number of car in stock right now: " + Car.carTotal); }

            if (Car.usedCars == 0) { Console.WriteLine("\n" + "We currently have no second-hand cars stocked."); }
            else { Console.WriteLine("Total number of second-hand cars currently stocked is: {0}", Car.usedCars); }

            if (Motorcycle.cycleTotal == 0) { Console.WriteLine("\n" + "We have sold all our available motorcycles!"); }
            else { Console.WriteLine("\n" + "Total number of motorcycles in stock right now: " + Motorcycle.cycleTotal); }

            if (Motorcycle.usedCycles == 0) { Console.WriteLine("\n" + "We currently have no second-hand motorcycles stocked."); }
            else { Console.WriteLine("The total number of second-hand motorcycles currently stocked is: {0}", Motorcycle.usedCycles); }

            Console.WriteLine("\n" + "The total number of motorcycles sold so far is: {0}", Motorcycle.cycleSold); 
            Console.WriteLine("The total number of cars sold so far is: {0}", Car.carSold);

            Console.WriteLine("\n" + "The total value of all the vehicles sold so far equals: £{0:N0}.00", totalSales);
            Console.WriteLine("\n" + "The value of all our currently stocked vehicles equals: £{0:N0}.00" + "\n", totalStock);
        }

        public virtual void Wheel()
        {
            Console.Write("\n{0} {1} has {2} wheels. \n", make, model, wheels);
        }
    }
}
