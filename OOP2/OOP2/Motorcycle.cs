using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Motorcycle : Vehicle
    {
        public string type;
        public static int cycleTotal;
        public static int cycleSold;
        public static int usedCycles;

        public Motorcycle(string make, string model, int price) : base(make, model, price)
        {
            this.type = "Motorcycle";
            cycleTotal++;
        }

        public Motorcycle(string make, string model, int price, int mileage) : base(make, model, price, mileage)
        {
            this.type = "Motorcycle";
            cycleTotal++;
            usedCycles++;
        }
        public override void Wheel()
        {
            wheels = 2;
            base.Wheel();
        }

    }
}