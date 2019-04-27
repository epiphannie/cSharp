using System;
namespace TreehouseDefense
{
    public class PowerfulTower : Tower
    {
        protected override int Power { get; } = 2;
        public PowerfulTower(MapLocation location ) : base(location)
        {

        }
    }
}
