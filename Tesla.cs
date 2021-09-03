using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The Tesla has recharged with {BatteryKWh} KWh!");
            Console.WriteLine();
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla with {MaximumOccupancy} passengers blazes by you. MMMmmmmmm!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla squeals around a {direction} turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently stops as if it never moved.");
        }
    }
}