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
            fxs.Turn("right");
            fxs.Stop();
            fxs.ChargeBattery();

            modelS.Drive();
            modelS.Turn("right");
            modelS.Stop();
            modelS.ChargeBattery();


            mx410.Drive();
            mx410.Turn("left");
            mx410.Stop();
            mx410.RefuelTank();

            trx1500.Drive();
            trx1500.Turn("left");
            trx1500.Stop();
            trx1500.RefuelTank();
        }
    }
}

