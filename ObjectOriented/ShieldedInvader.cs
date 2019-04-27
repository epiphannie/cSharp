using System;
namespace TreehouseDefense
{
    public class ShieldedInvader : Invader
    {
        private static System.Random _random = new System.Random();

        public ShieldedInvader(Path path) : base(path)
        {
        }

        public override void DecreaseHealth(int factor)
        {
            if(_random.NextDouble() < 0.5)
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
