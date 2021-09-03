using System;

namespace Garage
{
    public class Ram : Vehicle  // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            Console.WriteLine($"The Ram has refueled with {FuelCapacity} gallons!");
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram with {MaximumOccupancy} passengers growls by you. Rrrruuummmble!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram makes a heavy turn to the {direction}. Roarrrr!");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram slammed the breaks at a stop.");
        }
    }
}