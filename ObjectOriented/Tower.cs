using System;
namespace TreehouseDefense
{
    public class Tower
    {
        protected virtual int Range { get; } = 1;
        protected virtual int Power { get; } = 1;
        protected virtual double Accuracy { get; } = 0.75;

        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;

        public Tower (MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < Accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            //int index = 0;
            //while(index < invaders.Length)
            //{
            //    Invader invader = invaders[index];
            //    index++;
            //}

            //for(int i= 0; i < invaders.Length; i++)
            //{

            //}

            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, Range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(Power);
                        Console.WriteLine("Hit an invader");

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader at " + invader.Location + ".");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at and missed an invader");
                    }
                    break;
                }
            }
        }
    }
}