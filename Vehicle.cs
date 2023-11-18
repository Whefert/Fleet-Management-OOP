// Student Name: Jefferson Daley - Student ID: 20202583

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManagementApp
{
    class Vehicle
    {
        //Vehicle default constructor
        public Vehicle() { }

        //Vehicle overloaded constructor
        public Vehicle(string make, string model,
            ushort year, string colour, string fuelType,
            DateTime insuranceExpiryDate, DateTime fitnessExpiryDate)
        {
            Make = make;
            Model = model;
            Year = year;
            Colour = colour;
            FuelType = fuelType;
            InsuranceExpiryDate = insuranceExpiryDate;
            FitnessExpiryDate = fitnessExpiryDate;
        }

        public string? Make { get; set; }
        public string? Model { get; set; }
        public ushort? Year { get; set; }
        public string? Colour { get; set; }
        public string? FuelType { get; set; }
        public DateTime? InsuranceExpiryDate { get; set; }
        public DateTime? FitnessExpiryDate { get; set; }
        public string? Type { get; set; }

        public virtual void startEngine()
        {
            Console.WriteLine("Vehicle engine started.");
        }    
    }
}
