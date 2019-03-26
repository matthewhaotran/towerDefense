namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        private const int _range = 1;
        private const int _power = 1;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            

            foreach (Invader invader in invaders)
            {
                if(invader.isActive && _location.InRangeOf(invader.Location, _power))
                {
                    invader.DecreateHealth(_range);
                    break;
                }
            }
        }
    }
}