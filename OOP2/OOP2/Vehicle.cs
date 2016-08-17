using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{ 
    // Vehicle class for Motorcycle and Car to inherit from
    class Vehicle
    {
        // All the different variables that can apply to a vehicle
        public string make;
        public string model;
        public string type;

        public int price;
        public int sellPrice;
        public int mileage;
        public int wheels;

        public static int totalSales;
        public static int totalStock;

        public bool isNew;
        public bool sold;

        // First constructor takes make model and price
        public Vehicle(string make, string model, int price, string type)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.type = type;

            this.sold = false;
            this.isNew = true;
        }

        // Second constructor takes make model price and mileage for secondhand vehicles
        public Vehicle(string make, string model, int price, int mileage, string type)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.mileage = mileage;
            this.type = type;

            this.sold = false;
            this.isNew = false;
        }

        // The sell vehicle method takes parameter type, sold and sellprice as arguments when called 
        public void SellVehicle(string type, bool sold, int sellPrice)
        {
            // Checks for whether vehicle type is a car
            if (type == "car") {
                // Sold would be true if sold and declared in program
                this.sold = sold;
                // If statement checking if car is new, which if it isnt it decreases usedCars by 1
                if (isNew == false) { Car.usedCars--; }
                // Changes price to the sell price 
                this.sellPrice = sellPrice;
                // Increments car sold by 1 but decreases car total by 1
                Car.carSold++;
                Car.carTotal--;
            }

            // Checks for whether vehicle type is a motorcycle, other code is same as above.
            else if (type == "motorcycle") {
                this.sold = sold;
                if (isNew == false) { Motorcycle.usedCycles--; }
                this.sellPrice = sellPrice;
                Motorcycle.cycleSold++;
                Motorcycle.cycleTotal--;
            }

        }

        // List all the current vehicles we have added into our list
        public static void ListVehicles(List<Vehicle> vehicle)
        {
     
            // Starts a foreach vehicle in vehicle loop
            foreach (Vehicle v in vehicle)
            {
                // Checks if the vehicle is Car
                if (v is Car)
                {
                    // Check if the car is new 
                    if (v.isNew) {
                    // Returns the below details of the car along with mileage
                        Console.WriteLine("\n" + "The details of the car is: ");
                        Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00, Mileage: {3}.", v.make, v.model, v.price, v.mileage);
                    }
                    // Returns the car details but without mileage
                    else {
                        Console.WriteLine("\n" + "The details of the car is: ");
                        Console.WriteLine("Make: {0}, Model: {1}, Price: £{2:N0}.00.", v.make, v.model, v.price);
                    }
                    // Checks to see whether has been sold
                    if (v.sold == true) {
                        // If it was sold, shows the amount it was shown for
                        Console.WriteLine("This car has been sold, for a total of: £{0:N0}.00.", v.sellPrice);
             
                    }
                    // Otherwise state car has not been sold yet
                    else {
                        Console.WriteLine("This car has not been sold yet.");
                   
                    }   
                }

                // Checks whether vehicle is a motorcycle, rest of code is same as car.
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

        // Shows the stock and sales value of the car dealership so far.
        public static void StockSales(List<Vehicle> vehicle)
        {
            // initializes both total sales and stock to 0, otherwise they would increment each type this method is called.
            totalSales = 0;
            totalStock = 0;
        
            // Initializes the foreach to check through vehicle list
            foreach (Vehicle v in vehicle)
            {
               // Checks to see whether the vehicle is a car
                if (v is Car)
                {
                    // if sold is true, we add to the total sales the sold price of the car
                    if (v.sold == true) { totalSales += v.sellPrice;  }
                    // Else the total stock price goes up with the original brought price of the car
                    else { totalStock += v.price; }
                }

                // Checks to see whether the vehicle is a motorcycle, otherwise code is same as above.
                else if (v is Motorcycle)
                {
                    if (v.sold == true) { totalSales += v.sellPrice; }
                    else { totalStock += v.price; }
                }
            }           

            // Checks to see whether our total cars is 0, if so show messaged that we sold everything
            if (Car.carTotal == 0) { Console.WriteLine("\n" + "We have sold all our available cars!"); }
            // Else display number of cars we still have up for sale
            else { Console.WriteLine("\n" + "Total number of car in stock right now: " + Car.carTotal); }

            // Checks whether the used car value is 0 to determine how much secondhand cars we have, if its 0 we have none
            if (Car.usedCars == 0) { Console.WriteLine("\n" + "We currently have no second-hand cars stocked."); }
            // Otherwise we show the amount of second hand cars avaliable
            else { Console.WriteLine("Total number of second-hand cars currently stocked is: {0}", Car.usedCars); }

            // Same as above car, but we do it for motorcycles instead
            if (Motorcycle.cycleTotal == 0) { Console.WriteLine("\n" + "We have sold all our available motorcycles!"); }
            else { Console.WriteLine("\n" + "Total number of motorcycles in stock right now: " + Motorcycle.cycleTotal); }

            if (Motorcycle.usedCycles == 0) { Console.WriteLine("\n" + "We currently have no second-hand motorcycles stocked."); }
            else { Console.WriteLine("The total number of second-hand motorcycles currently stocked is: {0}", Motorcycle.usedCycles); }

            // Shows the number cars and motorcycles we have sold so far through accessing the property.
            // The {0} takes the argument for after the string has ended, in this case we enter cycleSold variable afterwards.
            Console.WriteLine("\n" + "The total number of motorcycles sold so far is: {0}", Motorcycle.cycleSold); 
            Console.WriteLine("The total number of cars sold so far is: {0}", Car.carSold);

            // Shows the total price amount we have sold all our vehicles for, otherwise shows how much our stock amount is worth in total.
            Console.WriteLine("\n" + "The total value of all the vehicles sold so far equals: £{0:N0}.00", totalSales);
            Console.WriteLine("\n" + "The value of all our currently stocked vehicles equals: £{0:N0}.00" + "\n", totalStock);
        }

        // Creates a virtual Wheel method for other derived classes to override, can differentiate the amount of wheels on vehicles.
        public virtual void Wheel()
        {
            Console.Write("\n{0} {1} has {2} wheels. \n", make, model, wheels);
        }
    }
}
