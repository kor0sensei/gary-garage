using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero() { MainColor = "Dark Grey", MaximumOccupancy = 1, BatteryKWh = 227.75 };
            Tesla modelS = new Tesla() { MainColor = "Frost White", MaximumOccupancy = 5, BatteryKWh = 290.50 };
            Cessna mx410 = new Cessna() { MainColor = "Cyan", MaximumOccupancy = 6, FuelCapacity = 22.50 };
            Ram trx1500 = new Ram() { MainColor = "Ruby Red", MaximumOccupancy = 8, FuelCapacity = 30.25 };

            fxs.Drive();
            modelS.Drive();
            mx410.Drive();
            trx1500.Drive();
        }
    }
}

