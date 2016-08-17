using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            string userInput;
            string addMake;
            string addModel;
            int addPrice = 0;
            string typeInput;

            List<Vehicle> vehicle = new List<Vehicle>();

            Vehicle carOne = new Car("Mazda", "Mazda3", 6000, 60000);
            vehicle.Add(carOne);

            Vehicle carTwo = new Car("Honda", "Civic", 5500, 65000);
            vehicle.Add(carTwo);

            Vehicle carThree = new Car("BMW", "3 Series", 10000);
            vehicle.Add(carThree);

            Vehicle carFour = new Car("Ford", "Fiesta", 8000);
            vehicle.Add(carFour);

            Vehicle carFive = new Car("Volkswagen", "Polo", 9000, 50000);
            vehicle.Add(carFive);

            Vehicle cycleOne = new Motorcycle("Suzuki", "Hayabusa", 9000, 40000);
            vehicle.Add(cycleOne);

            Vehicle cycleTwo = new Motorcycle("Yamaha", "YZF-R1M", 8000);
            vehicle.Add(cycleTwo);

            Vehicle cycleThree = new Motorcycle("Hyosuing", "GT650R", 10000);
            vehicle.Add(cycleThree);

            Vehicle cycleFour = new Motorcycle("BMW", "S1000RR", 9500, 50000);
            vehicle.Add(cycleFour);

            //carOne.SellVehicle("car", true, 7000);
            carTwo.SellVehicle("car", true, 6500);
            //carThree.SellVehicle("car", true, 9500);
            carFour.SellVehicle("car", true, 10000);
            //carFive.SellVehicle("car", true, 9500);

            cycleOne.SellVehicle("motorcycle", true, 10000);
            //cycleTwo.SellVehicle("motorcycle", true, 8500);
            cycleThree.SellVehicle("motorcycle", true, 9900);
            //cycleFour.SellVehicle("motorcycle", true, 9000);

            Console.WriteLine("Hello, you can access various functions to our Vehicles List here." + "\n");
            Console.WriteLine("Option 1 - Add Car - Push A");
            Console.WriteLine("Option 2 - Sell Vehicle - Push S");
            Console.WriteLine("Option 3 - List Vehicles - Push V");
            Console.WriteLine("Option 4 - List Stock & Sales - Push E");
            Console.WriteLine("Option 5 - Wheels of Vehicles - Push W");
            Console.WriteLine("Option 6 - Exit Program - Push X" + "\n");

            do
            {
                userInput = Console.ReadLine().ToLower();
                
                switch (userInput)
                {
                    case "a":
                        Console.WriteLine("\n" + "Please type in the make of the car you want to add." + "\n");
                        addMake = Console.ReadLine();

                        Console.WriteLine("\n" + "Now, please type in the model of the car you want to add." + "\n");
                        addModel = Console.ReadLine();

                        Console.WriteLine("\n" + "Finally, please enter a price for the car you want to add." + "\n");
                        userInput = Console.ReadLine();

                        try { addPrice = Convert.ToInt32(userInput); }
                        catch(System.FormatException e) { Console.WriteLine("\n" + "Please enter an actual number."); }

                        Console.WriteLine("\n" + "Please wait a moment, adding your car into the list ...");
                        vehicle.Add(new Car(addMake, addModel, addPrice));

                        Console.WriteLine("\n" + "Successfully added {0} {1}! Here is the new list: ", addMake, addModel);
                        Vehicle.ListVehicles(vehicle);

                        break;

                    case "s":
                        Console.WriteLine("\n" + "Sell Vehicle option was selected, do you want to sell a Car or Motorcycle?");
                        typeInput = Console.ReadLine().ToLower();

                        if (typeInput == "car" || typeInput == "motorcycle")
                        {
                            Console.WriteLine("\n" + "What is the model of the {0} you wish to sell?", typeInput);
                            userInput = Console.ReadLine();

                            int index = vehicle.FindIndex(v => v.model == userInput);

                            if (index >= 0)
                            {
                                Console.WriteLine("\n" + "That model was found in the list! how much do you want to sell it for?");
                                userInput = Console.ReadLine();
                                addPrice = Convert.ToInt32(userInput);

                                Console.WriteLine("\n" + "Price accepted, confirming the car sale now ...");
                                Vehicle foundVehicle = new Vehicle("","", 0);
                                foundVehicle = vehicle[index];

                                if (foundVehicle.sold == true) {
                                    Console.WriteLine("\n" + "Request denied, this vehicle has already been sold!");
                                }

                                else {
                                    Console.WriteLine("\n{0} has been sold for £{1:N0}.00!", foundVehicle.model, addPrice);
                                    foundVehicle.SellVehicle(typeInput, true, addPrice);
                                }
                                
                            }

                            else
                            {
                                Console.WriteLine("not found!");
                            }


                            /*foreach (Vehicle v in vehicle) {
                                if (v.model == userInput) {

                                }

                                else if (v.model != userInput) { Console.WriteLine("\n{0) was not found in the list!", userInput); }
                           }*/
                        }

                        else { Console.WriteLine("\nWe do not stock {0}s here!", userInput); }
                        break;

                    case "v":
                        Console.WriteLine("\n" + "Here is a list of all our vehicles: ");
                        Vehicle.ListVehicles(vehicle);
                        break;

                    case "e":
                        Console.WriteLine("\n" + "Here is records of our stock and sales along with amount.");
                        Vehicle.StockSales(vehicle);
                        break;

                    case "w":
                        foreach (Vehicle v in vehicle) {
                            v.Wheel();
                        }
                        break;

                    case "x":
                        exit = true;
                        Environment.Exit(0);
                        break;

                }

                Console.WriteLine("\n" + "Want to choose another command? If so choose from: A, S, V, E, W.");
                Console.WriteLine("Otherwise, Press X to exit the program." + "\n");

            } while (exit == false);
        }
    }
}
