using System;
namespace TreehouseDefense
{
    public class SniperTower : Tower
    {
        protected override double Accuracy { get; } = 0.9;
        public SniperTower(MapLocation location ) : base(location)
        {

        }
    }
}
