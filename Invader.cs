namespace TreehouseDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public int Health { get; set; } = 2;

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool isNeutralized => Health <= 0;

        public bool isActive => !(isNeutralized || HasScored);

        public Invader(Path path) { _path = path; }

        public void Move() => _pathStep += 1;

        public void DecreateHealth(int factor) => Health -= factor;
    }
}