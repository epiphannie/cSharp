using System;
namespace TreehouseDefense
{
    public class FastInvader : Invader
    {
        protected override int StepSize { get; } = 2;

        public FastInvader(Path path) : base(path)
        {

        }
    }
}
