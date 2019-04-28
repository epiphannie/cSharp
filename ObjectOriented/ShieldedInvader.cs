using System;
namespace TreehouseDefense
{
    public class ShieldedInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        public ShieldedInvader(Path path) : base(path)
        {
        }

        public override void DecreaseHealth(int factor)
        {
            if(Random.NextDouble() < 0.5)
            {
                base.DecreaseHealth(factor);
            }
            else
            {
                Console.WriteLine("Shot at a shielded invader but no damage was done.");
            }
        }
    }
}
