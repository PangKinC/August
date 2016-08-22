using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // Class Motorcycle (Derived) inherits from Vehicle class (Base)
    class Motorcycle : Vehicle
    {
        // We only need to declare these unique variables for Motorcycle, the other can be inherited from Vehicle.
        public static int cycleTotal;
        public static int cycleSold;
        public static int usedCycles;

        // First constructor which represents a brand new motorcycle
        public Motorcycle(string make, string model, int price, string type = "motorcycle") : base(make, model, price, type)
        {
            // Increments the total motorcycles we have by 1
            cycleTotal++;
        }

        // Second constructor to represent a second-hand motorcycle with new paramater mileage included
        public Motorcycle(string make, string model, int price, int mileage, string type = "motorcycle") : base(make, model, price, mileage, type)
        {
            // Increments the total and used (second-hand) motorcycles we have by 1
            cycleTotal++;
            usedCycles++;
        }

        // The virtual method Wheel we are overriding, note that the number of wheels is 2 here (for a motorcycle)
        public override void Wheel()
        {
            wheels = 2;
            base.Wheel();
        }

    }
}