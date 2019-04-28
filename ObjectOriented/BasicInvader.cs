using System;
namespace TreehouseDefense
{
    public class BasicInvader : Invader
    {
        public override int Health { get; protected set; } = 2;

        public BasicInvader(Path path) : base(path)
        {

        }
    }
}
