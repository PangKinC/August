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


            /*foreach (Vehicle v in vehicle)
            {
                v.Wheel();
            }*/

            //Vehicle.TotalSales(vehicle);

            Console.WriteLine("Hello, you can add new cars into the list from this program." + "\n");

            Console.WriteLine("Option 1 - Add Car - Push A");
            Console.WriteLine("Option 2 - Exit Program - Push E" + "\n");

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
                        Vehicle.TotalSales(vehicle);

                        break;

                    case "e":
                        exit = true;
                        Environment.Exit(0);
                        break;

                }

                Console.WriteLine("\n" + "Add another Car? Press A.");
                Console.WriteLine("Otherwise, Press E to exit the program." + "\n");

            } while (exit == false);
        }
    }
}
