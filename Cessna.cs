using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The Cessna has refueled with {FuelCapacity} gallons!");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna with {MaximumOccupancy} passengers flashes by you like a hurricane. Zoooooom!");
        }
    }
}