namespace auernautica_imperiali {
    public abstract class AUnit : Point {
        private int _structure;
        private int _speed;
        private int _throttle;
        private int _minSpeed;
        private int _maxSpeed;
        private int _maneuver;
        private int _handling;
        private int _altitude;
        private int _maxAltitude;
        private int _team;

        protected AUnit(int x, int y, int z, int structure, int speed, int throttle, int minSpeed, int maxSpeed, int maneuver, int handling, int maxAltitude, int team) : base(x, y, z) {
            _structure = structure;
            _speed = speed;
            _throttle = throttle;
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _maneuver = maneuver;
            _handling = handling;
            _maxAltitude = maxAltitude;
            _team = team;
        }
    }
}