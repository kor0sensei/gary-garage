using System;

namespace Garage
{
    public class Zero: Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            Console.WriteLine($"The Zero has recharged with {BatteryKWh} KWh!");
        }

        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Zero with {MaximumOccupancy} passengers zips by you. Yeeeooowww!");
        }
    }
}