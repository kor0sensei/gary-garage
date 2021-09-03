using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The Tesla has recharged with {BatteryKWh} KWh!");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla with {MaximumOccupancy} passengers blazes by you. MMMmmmmmm!");
        }
    }
}