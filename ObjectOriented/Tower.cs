using System;
namespace TreehouseDefense
{
    public class Tower
    {
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = 0.75;

        private static readonly System.Random _random = new System.Random();

        private readonly MapLocation _location;

        public Tower (MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
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
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Hit an invader");

                        if(invader.IsNeutralized)
                        {
                            Console.WriteLine("Neutralized an invader");
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