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
            // Declares the variables we will be using in this program
            bool exit = false;
            string userInput;
            string addMake;
            string addModel;
            int addPrice = 0;
            int addMileage = 0;
            string typeInput;

            // Creates a new list of Vehicle to add different vehicle types into
            List<Vehicle> vehicle = new List<Vehicle>();

            // Creates the Car objects with details as arguments, note that some have mileage (second constructor) and some don't
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

            // Creates the Motorcycle objects with details as arguments, note that some have mileage (second constructor) and some don't
            Vehicle cycleOne = new Motorcycle("Suzuki", "Hayabusa", 9000, 40000);
            vehicle.Add(cycleOne);

            Vehicle cycleTwo = new Motorcycle("Yamaha", "YZF-R1M", 8000);
            vehicle.Add(cycleTwo);

            Vehicle cycleThree = new Motorcycle("Hyosuing", "GT650R", 10000);
            vehicle.Add(cycleThree);

            Vehicle cycleFour = new Motorcycle("BMW", "S1000RR", 9500, 50000);
            vehicle.Add(cycleFour);


            // Calls the SellVehicle method from Vehicle class on some of the above vehicles.
            //carOne.SellVehicle("car", true, 7000);
            carTwo.SellVehicle("car", true, 6500);
            //carThree.SellVehicle("car", true, 9500);
            carFour.SellVehicle("car", true, 10000);
            //carFive.SellVehicle("car", true, 9500);

            cycleOne.SellVehicle("motorcycle", true, 10000);
            //cycleTwo.SellVehicle("motorcycle", true, 8500);
            cycleThree.SellVehicle("motorcycle", true, 9900);
            //cycleFour.SellVehicle("motorcycle", true, 9000);

            // The opening lines of the program, showing what keys user can push
            Console.WriteLine("Hello, you can access various functions to our Vehicles List here." + "\n");
            Console.WriteLine("Option 1 - Add Car - Push A");
            Console.WriteLine("Option 2 - Sell Vehicle - Push S");
            Console.WriteLine("Option 3 - List Vehicles - Push V");
            Console.WriteLine("Option 4 - List Stock & Sales - Push E");
            Console.WriteLine("Option 5 - Wheels of Vehicles - Push W");
            Console.WriteLine("Option 6 - Exit Program - Push X" + "\n");

            // Initializes the do while loop, which carries on until exit is pressed.
            do
            {
                // Takes the user inputted value
                userInput = Console.ReadLine().ToLower();
                
                // Starts a switch statement block
                switch (userInput)
                {
                    // For case A, we take three different user inputs, and then pass them as arguments to create add a new
                    case "a":

                        // Asks the user whether they want to add a car or motorcycle to list
                        Console.WriteLine("\n" + "Adding a new vehicle to the list, please choose from Car or Motorcycle");
                        userInput = Console.ReadLine().ToLower();
                            
                        // If the user input was a car, do the below code
                        if (userInput == "car")
                        {
                            Console.WriteLine("\n" + "Please type in the make of the car you want to add.");
                            addMake = Console.ReadLine();

                            Console.WriteLine("\n" + "Now, please type in the model of the car you want to add.");
                            addModel = Console.ReadLine();

                            Console.WriteLine("\n" + "Finally, please enter a price for the car you want to add.");
                            userInput = Console.ReadLine();

                            try { addPrice = Convert.ToInt32(userInput); }
                            catch (System.FormatException e) { Console.WriteLine("\n" + "Please enter an actual number."); }

                            // This section asks the user for a mileage, which determines whether car is new or not
                            Console.WriteLine("\n" + "Is this a new a car?, if yes enter the mileage, if not leave blank.");
                            userInput = Console.ReadLine();

                            // If the user entered some text, we try convert it into a number
                            if (userInput != "") {   
                                addMileage = Convert.ToInt32(userInput);
                                Console.WriteLine("\n" + "Please wait a moment, adding your car into the list ...");
                                // Adds a new car with the second constructor, which has mileage as parameter
                                vehicle.Add(new Car(addMake, addModel, addPrice, addMileage));
                            }

                            else {
                                Console.WriteLine("\n" + "Please wait a moment, adding your car into the list ...");
                                // Adds the car with the three user inputs as arguments
                                vehicle.Add(new Car(addMake, addModel, addPrice));
                            }

                            // Confirms that the car was added into the list, then shows the list of all vehicles currently in list
                            Console.WriteLine("\n" + "Successfully added {0} {1}! Here is the new list: ", addMake, addModel);
                            Vehicle.ListVehicles(vehicle);
                        }

                        // If the user input was a motorcycle, do the below code
                        else if (userInput == "motorcycle")
                        {
                            Console.WriteLine("\n" + "Please type in the make of the motorcycle you want to add.");
                            addMake = Console.ReadLine();

                            Console.WriteLine("\n" + "Now, please type in the model of the motorcycle you want to add.");
                            addModel = Console.ReadLine();

                            Console.WriteLine("\n" + "Finally, please enter a price for the motorcycle you want to add.");
                            userInput = Console.ReadLine();

                            try { addPrice = Convert.ToInt32(userInput); }
                            catch (System.FormatException e) { Console.WriteLine("\n" + "Please enter an actual number."); }

                            // This section asks the user for a mileage, which determines whether motorcycle is new or not
                            Console.WriteLine("\n" + "Is this a new a motorcycle?, if yes enter the mileage, if not leave blank.");
                            userInput = Console.ReadLine();

                            // If the user entered some text, we try convert it into a number
                            if (userInput != "")
                            {
                                addMileage = Convert.ToInt32(userInput);
                                Console.WriteLine("\n" + "Please wait a moment, adding your motorcycle into the list ...");
                                // Adds a new motorcycle with the second constructor, which has mileage as parameter
                                vehicle.Add(new Motorcycle(addMake, addModel, addPrice, addMileage));
                            }

                            else {
                                Console.WriteLine("\n" + "Please wait a moment, adding your motorcycle into the list ...");
                                // Adds the car with the three user inputs as arguments
                                vehicle.Add(new Motorcycle(addMake, addModel, addPrice));
                            }

                            // Confirms that the motorcycle was added into the list, then shows the list of all vehicles currently in list
                            Console.WriteLine("\n" + "Successfully added {0} {1}! Here is the new list: ", addMake, addModel);
                            Vehicle.ListVehicles(vehicle);
                        }

                        break;

                    // For case S, we try to sell a vehicle in our list
                    case "s":
                        // Ask whether user wants to sell a car or motorcycle
                        Console.WriteLine("\n" + "Sell Vehicle option was selected, do you want to sell a Car or Motorcycle?");
                        typeInput = Console.ReadLine().ToLower();

                        if (typeInput == "car" || typeInput == "motorcycle")
                        {
                            // Asks the user to type in the model of the vehicle they want to sell
                            Console.WriteLine("\n" + "What is the model of the {0} you wish to sell?", typeInput);
                            userInput = Console.ReadLine();

                            // Searches through the list to see if matches (uses a lambda expression to get the model property)
                            int index = vehicle.FindIndex(v => v.model == userInput);

                            // Confirms that the match was found
                            if (index >= 0) {
                                // Asks how much the user would like to sell the vehicle for
                                Console.WriteLine("\n" + "That model was found in the list! how much do you want to sell it for?");
                                userInput = Console.ReadLine();
                                addPrice = Convert.ToInt32(userInput);

                                // We initialize a empty vehicle object to match it to foundVehicle
                                Console.WriteLine("\n" + "Price accepted, confirming the car sale now ...");
                                Vehicle foundVehicle = new Vehicle("","", 0, "");
                                foundVehicle = vehicle[index];

                                // If the vehicle sold property is true, then we can't sell it
                                if (foundVehicle.sold == true) {
                                    Console.WriteLine("\n" + "Request denied, this vehicle has already been sold!");
                                }

                                // Otherwise we sell the vehicle with user inputs as arguments
                                else {
                                    Console.WriteLine("\n{0} has been sold for £{1:N0}.00!", foundVehicle.model, addPrice);
                                    foundVehicle.SellVehicle(typeInput, true, addPrice);
                                }         

                            }

                            // The input from user couldn't match with a model found in the list
                            else { Console.WriteLine("\n{0) was not found in the list!", userInput); }
                        }

                        // Shows that we don't have that type of vehicle (not a car or motorcycle) in list
                        else { Console.WriteLine("\nWe do not stock {0}s here!", userInput); }
                        break;

                    // Case V calls either a single vehicle or all the vehicles in the list
                    case "v":
                        // Gets user input and asks to type either one or all for single or every vehicle in list
                        Console.WriteLine("\nDo you want to display a single vehicle or all of them?");
                        Console.WriteLine("For a single vehicle type: (one), for all vehicles type: (all)");

                        userInput = Console.ReadLine().ToLower();
                        
                        // If user input typed was one
                        if (userInput == "one") {

                            // Asks for user input to try locate the vehicle model in the list
                            Console.WriteLine("\nPlease type in the model of the vehicle you want to list.");

                            userInput = Console.ReadLine();
                            // Uses lambda expression to find the model and assigns it to a integer check model
                            int checkModel = vehicle.FindIndex(v => v.model == userInput);

                            // If check was found, it would be either equal or over 0
                            if (checkModel >= 0) {
                                // We create a empty Vehicle object and assign it with checkModel which matches with the model in question
                                Vehicle vehicleMatch = new Vehicle("", "", 0, "");
                                vehicleMatch = vehicle[checkModel];

                                // Calls the ListVehicle method from Vehicle to display the single vehicle details
                                Vehicle.ListVehicle(vehicleMatch);
                            }
                            // Else statement is true when the model was not matched inside list
                            else { Console.WriteLine("\nThat model was not found inside the list!"); }
                        }   

                        // If the gotten user input was all
                        else if (userInput == "all") {
                            // We show the list of all the vehicles inside our list.
                            Console.WriteLine("\n" + "Here is a list of all our vehicles: ");
                            Vehicle.ListVehicles(vehicle);
                        }

                        break;

                    // Case E shows the StockSales method from Vehicle class, to show all the total price and stock amount
                    case "e":
                        Console.WriteLine("\n" + "Here is records of our stock and sales along with amount.");
                        Vehicle.StockSales(vehicle);
                        break;

                    // Case W calls the virtual method Wheel and prints screen how much wheels each vehicle has.
                    case "w":
                        foreach (Vehicle v in vehicle) {
                            v.Wheel();
                        }
                        break;

                    // Case E exits the program
                    case "x":
                        exit = true;
                        Environment.Exit(0);
                        break;

                }

                // When you reach end of the loop, we show the list of commands again as a reminder
                Console.WriteLine("\n" + "Want to choose another command? If so choose from: A, S, V, E, W.");
                Console.WriteLine("Otherwise, Press X to exit the program." + "\n");

            } while (exit == false);
        }
    }
}
