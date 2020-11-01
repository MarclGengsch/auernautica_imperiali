using System.Collections.Generic;

namespace auernautica_imperiali {
    public abstract class AUnit {
        private int _structure;
        private int _speed;
        private int _throttle;
        private int _minSpeed;
        private int _maxSpeed;
        private int _maneuver;
        private int _handling;
        private int _maxAltitude;
        private int _team;
        private int _cost;

        public int Cost
        {
            get => _cost;
            set => _cost = value;
        }

        private Point _point;

        public Point Point {
            get { return _point; }
            set { _point = value; }
        }


        protected AUnit(Point xyz, int structure, int speed, int throttle, int minSpeed, int maxSpeed,
            int maneuver, int handling, int maxAltitude, int team, int cost) {
            _structure = structure;
            _speed = speed;
            _throttle = throttle;
            _minSpeed = minSpeed;
            _maxSpeed = maxSpeed;
            _maneuver = maneuver;
            _handling = handling;
            _maxAltitude = maxAltitude;
            _team = team;
            _point = xyz;
            _cost = cost;
        }

        public abstract bool JoinArmy();
    }
}