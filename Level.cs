namespace TreehouseDefense {
    class Level 
    {
        private Invader[] _invaders;

        public Tower[] Towers {get; set;}

        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }
        //Returns true if player beat level, false if they lost
        public bool Play()
        {
            int remainingInvaders = _invaders.Length;

            while(remainingInvaders > 0)
            {
                foreach(Tower tower in Towers)
                {
                    tower.FireOnInvaders(_invaders);
                }

                remainingInvaders = 0;
                foreach(Invader invader in _invaders)
                {
                    if(invader.isActive)
                    {
                        invader.Move();
                        if(invader.HasScored)
                        {
                            return false;
                        }
                        remainingInvaders++;
                    }


                }
            }

            return true;
        }
    }
}