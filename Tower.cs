using System;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = 0.75;

        private static readonly Random _random = new Random();

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool isSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            

            foreach (Invader invader in invaders)
            {
                if(invader.isActive && _location.InRangeOf(invader.Location, _power))
                {
                    if(isSuccessfulShot())
                    {
                        invader.DecreateHealth(_range);

                        if(invader.isNeutralized)
                        {
                            Console.WriteLine("Invader has been neutralized");
                        }
                    }
                    else{
                        Console.WriteLine("Missed!");
                    }
                    break;
                }
            }
        }
    }
}