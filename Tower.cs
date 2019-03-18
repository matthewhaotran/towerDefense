namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        public Tower(MapLocation location)
        {
            _location = location;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if(invader.isActive && _location.InRangeOf(invader.Location, 1))
                {
                    invader.DecreateHealth(1);
                    break;
                }
            }
        }
    }
}