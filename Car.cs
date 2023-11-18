// Student Name: Jefferson Daley - Student ID: 20202583

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementApp
{
    class Car : Vehicle
    {
        public Car() : base()
        {
            this.Type = "Car";
        }

        public Car(string make, string model,
            ushort year, string colour, string fuelType,
            DateTime insuranceExpiryDate, DateTime fitnessExpiryDate) :
            base(make, model, year, colour, fuelType, insuranceExpiryDate, fitnessExpiryDate)
        {
            this.Type = "Car";
        }

        public override void startEngine()
        {
            Console.WriteLine("Car engine started.");
        }
    }
}
