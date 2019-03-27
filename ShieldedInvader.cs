using System;

namespace TreehouseDefense
{
    class ShieldedInvader : Invader
    {
        private static Random _random = new Random();

        public ShieldedInvader(Path path) : base(path)
        {

        }

        public override void DecreateHealth(int factor) 
        {
            if(_random.NextDouble() < 0.5)
            {
                base.DecreateHealth(factor);
            }
            else
            {
                System.Console.WriteLine("Shot at a Shielded Invader but it sustained no damage");
            }
        }
    }
}