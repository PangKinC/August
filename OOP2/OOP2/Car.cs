using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    // Class Car (Derived) inherits from Vehicle class (Base)
    class Car : Vehicle
    {
        // We only need to declare these unique variables for Car, the other can be inherited from Vehicle.
        public static int carTotal;
        public static int carSold;
        public static int usedCars;

        // First constructor which represents a brand new car
        public Car(string make, string model, int price, string type = "car") : base(make, model, price, type)
        {
            // Increments the total cars we have by 1
            carTotal++;
        }

        // Second constructor to represent a second-hand car with new paramater mileage included
        public Car(string make, string model, int price, int mileage, string type = "car") : base(make, model, price, mileage, type)
        {
            // Increments the total and used (second-hand) cars we have by 1
            carTotal++;
            usedCars++;
        }

        // The virtual method Wheel we are overriding, note that the number of wheels is 4 here (for a car)
        public override void Wheel()
        {
            wheels = 4;
            base.Wheel();
        }

    }
}
