using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class Car : Vehicle
    {
        public string type;
        public static int carTotal;
        public static int carSold;
        public static int usedCars;

        public Car(string make, string model, int price) : base(make, model, price)
        {
            this.type = "Car";
            carTotal++;
        }

        public Car(string make, string model, int price, int mileage) : base(make, model, price, mileage)
        {
            this.type = "Car";
            carTotal++;
            usedCars++;
        }

        public override void Wheel()
        {
            wheels = 4;
            base.Wheel();
        }

    }
}
