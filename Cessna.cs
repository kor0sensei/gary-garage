using System;

namespace Garage
{
    public class Cessna : Vehicle
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The Cessna has refueled with {FuelCapacity} gallons!");
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna with {MaximumOccupancy} passengers flashes by you like a hurricane. Zoooooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Cessna rapidly makes a sharp turn to the {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Cessna rolls down the runway for a mile and stops.");
        }
    }
}