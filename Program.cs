// Student Name: Jefferson Daley - Student ID: 20202583

using Microsoft.VisualBasic;
using System.Globalization;

namespace FleetManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create list to contain all created vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            string selection= "";

            //ask user for details to create vehicle
            promptUserForVehicleCreation(vehicles, selection);

            while (true) { 
                Console.WriteLine("\nWould you like to add another vehicle? (y/n)");
                string choice = Console.ReadLine();
                if(choice == "y")
                {
                    selection = "";
                    promptUserForVehicleCreation(vehicles, selection);
                }
                else if(choice == "n") {
                    Console.WriteLine("All vehicles in fleet: ");
                    int counter= 0;
                    vehicles.ForEach((vehicle) => {
                          counter++;
                          Console.WriteLine(counter + ". " + vehicle.Type + ": " + vehicle.Make + " " + vehicle.Model + " " + vehicle.Year);
                    });
                    break;
                }
                else{
                    Console.WriteLine("Invalid choice, please try again by selecting (y/n).");
                }
            }



        }

        static Vehicle createVehicle(string vehicleType)
        {
           // fetch the en-GB culture
           CultureInfo ukCulture = new CultureInfo("en-GB");
           string make, model, colour, fuelType;
           ushort year;
           DateTime insuranceExpiryDate, fitnessExpiryDate;
           
           Console.Write(vehicleType + " make: ");
           make = Console.ReadLine().Trim();

           Console.Write(vehicleType + " model: ");
           model = Console.ReadLine().Trim();
           while (true) {
               try
               {
                   Console.Write(vehicleType + " year e.g. 2020? ");
                   year = ushort.Parse(Console.ReadLine());
                   break;
               }
               catch (FormatException)
               {
                   Console.WriteLine("Incorrect year input. Please try again e.g. 2020\n");
               }
           }
           Console.Write(vehicleType + " colour: ");
           colour = Console.ReadLine();

           Console.Write(vehicleType + " fuelType: ");
           fuelType = Console.ReadLine().Trim();
            while (true)
            {
                try
                {
                    Console.Write(vehicleType + " insurance expiry date e.g 16/2/2024? ");
                    string date = Console.ReadLine();
                    insuranceExpiryDate =  DateTime.Parse(date, ukCulture.DateTimeFormat);
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect date format. Please try again e.g. 16/2/2024\n");
                } 
            }
            while (true)
            {
                try
                {
                    Console.Write(vehicleType + " fitness expiry date: e.g. 16/2/2024? ");
                    fitnessExpiryDate = DateTime.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect date format. Please try again e.g. 16/2/2024\n");
                }
            }

            if(vehicleType == "Car")
            {
                Car newCar = new Car(make, model, year, colour, fuelType, insuranceExpiryDate, fitnessExpiryDate);
                Console.WriteLine("Car created succesfully");
                return newCar;
            }
            else if (vehicleType == "Van")
            {
                Van newVan = new Van(make, model, year, colour, fuelType, insuranceExpiryDate, fitnessExpiryDate);
                Console.WriteLine("Van created succesfully");
                return newVan;
            }
            else{
                SUV newSUV = new SUV(make, model, year, colour, fuelType, insuranceExpiryDate, fitnessExpiryDate);
                Console.WriteLine("SUV created succesfully");
                return newSUV;
            }
        }
        static void promptUserForVehicleCreation(List<Vehicle> vehicles, string selection )
        {
            while (true)
            {
                //Ask user what type of vehicle they'd like to create?
                Console.WriteLine("What kind of vehicle would you like to create?\n" +
                    "a. Car \n" +
                    "b. Van\n" +
                    "c. SUV\n");

                selection = Console.ReadLine().ToLower();

                if (selection == "a") { vehicles.Add(createVehicle("Car")); break; }
                else if (selection == "b") { vehicles.Add(createVehicle("Van")); break; }
                else if (selection == "c") { vehicles.Add(createVehicle("SUV")); break; }
                else
                {
                    Console.WriteLine("Incorrect option selected. Please try again " +
                        "e.g. Type a, b, or c\n");
                }
            }
        }
    }
}