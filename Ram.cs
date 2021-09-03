using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The Ram has refueled with {FuelCapacity} gallons!");
        }

        public override void Drive()
        {
                        Console.WriteLine($"The {MainColor} Ram with {MaximumOccupancy} passengers growls by you. Rrrruuummmble!");
        }
    }
}