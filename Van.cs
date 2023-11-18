// Student Name: Jefferson Daley - Student ID: 20202583

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementApp
{
    class Van : Vehicle
    {
        public Van() : base()
        {
            this.Type = "Van";
        }

        public Van(string make, string model,
            ushort year, string colour, string fuelType,
            DateTime insuranceExpiryDate, DateTime fitnessExpiryDate) :
            base(make, model, year, colour, fuelType, insuranceExpiryDate, fitnessExpiryDate)
        {
            this.Type = "Van";
        }

        public override void startEngine()
        {
            Console.WriteLine("Van engine started.");
        }
    }
}
