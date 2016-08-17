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
            this.make = make;
            this.model = model;
            this.price = price;

            this.sold = false;
            this.isNew = true;

            carTotal++;
        }

        public Car(string make, string model, int price, int mileage) : base(make, model, price, mileage)
        {
            this.type = "Car";
            this.make = make;
            this.model = model;
            this.price = price;
            this.mileage = mileage;

            this.sold = false;
            this.isNew = false;

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
